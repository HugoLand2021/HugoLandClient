using Hugo_LAND.Client.HugoLandServices;
using Hugo_LAND.Client.Validators;
using Hugo_LAND.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hugo_LAND.Client.Vue
{
    public partial class frmCreateClass : Form
    {
        private readonly WorldServiceClient worldServiceClient = new WorldServiceClient();
        private readonly ClassServiceClient classServiceClient = new ClassServiceClient();
        private List<WorldItemDTO> worldsList;
        private readonly CreateClassValidator createClassValidator;

        public frmCreateClass()
        {
            InitializeComponent();
            worldsList = new List<WorldItemDTO>();
            LoadWorlds();
            createClassValidator = new CreateClassValidator();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            List<string> errorsStats = VerifyInfo();
            if (errorsStats.Count > 0)
            {
                ClassDetailsDTO newClass = new ClassDetailsDTO()
                {
                    NomClasse = txtName.Text,
                    Description = txtDescription.Text,
                    StatBaseStr = 0,
                    StatBaseDex = 0,
                    StatBaseInt = 0,
                    StatBaseVitalite = 0
                };
                var result = createClassValidator.Validate(newClass);
                foreach (var item in result.Errors)
                    errorsStats.Add(item.ErrorMessage);

                MessageBox.Show(string.Join("\n", errorsStats), "Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ClassDetailsDTO newClass = new ClassDetailsDTO()
                {
                    NomClasse = txtName.Text,
                    Description = txtDescription.Text,
                    StatBaseStr = int.Parse(txtStr.Text),
                    StatBaseDex = int.Parse(txtDex.Text),
                    StatBaseInt = int.Parse(txtInt.Text),
                    StatBaseVitalite = int.Parse(txtVitality.Text)
                };

                var result = createClassValidator.Validate(newClass);
                WorldItemDTO world = worldsList.FirstOrDefault(w => w.Description == comboWorlds.Text);

                if (!result.IsValid)
                {
                    MessageBox.Show(string.Join("\n", result.Errors.ToList()), "Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        classServiceClient.CreerClasse(newClass, world);
                        MessageBox.Show("The user has been created", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("An error has occured with the creation of the user", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void LoadWorlds()
        {
            try
            {
                worldsList = worldServiceClient.GetAllWorldNames().ToList();
                comboWorlds.DataSource = worldsList.Select(w => w.Description).ToList();
            }
            catch
            {
                MessageBox.Show("No worlds have been found or a network error has occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
        private List<string> VerifyInfo()
        {
            List<string> errors = new List<string>();
            //Stats
            int StatStr, StatDex, StatInt, StatVitality;
            bool isNumericStr = int.TryParse(txtStr.Text, out StatStr);
            bool isNumericDex = int.TryParse(txtDex.Text, out StatDex);
            bool isNumericInt = int.TryParse(txtInt.Text, out StatInt);
            bool isNumericVitality = int.TryParse(txtVitality.Text, out StatVitality);
            if (!isNumericStr || StatStr < 0 || StatStr > 10)
                errors.Add("Please provide a valid base stat str between(inclusive) 0 and 10.");
            if (!isNumericDex || StatDex < 0 || StatDex > 10)
                errors.Add("Please provide a valid base stat dex between(inclusive) 0 and 10.");
            if (!isNumericInt || StatInt < 0 || StatInt > 10)
                errors.Add("Please provide a valid base stat int between(inclusive) 0 and 10.");
            if (!isNumericVitality || StatVitality < 0 || StatVitality > 10)
                errors.Add("Please provide a valid base stat vitality between(inclusive) 0 and 10.");

            //World
            WorldItemDTO w;
            try
            {
                w = worldsList.First(wo => wo.Description == comboWorlds.Text);
            }
            catch 
            {
                w = null;
            }
            if (string.IsNullOrEmpty(comboWorlds.Text) || w == null)
                errors.Add("Please select a valid world.");

            ////Class name PAS OBLIGÉ
            //ClassDetailsDTO c = classServiceClient.GetClasseByName(txtName.Text);
            //if (c != null)
            //    errors.Add("A class using this name already exists!");
            return errors;
        }
    }
}
