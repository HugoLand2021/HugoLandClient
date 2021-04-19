using Hugo_LAND.Client.HugoLandServices;
using Hugo_LAND.Client.Validators;
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
    public partial class frmModifyDeleteClass : Form
    {
        private List<ClassDetailsDTO> classes = new List<ClassDetailsDTO>();
        private ClassServiceClient classServiceClient = new ClassServiceClient();
        private readonly CreateClassValidator createClassValidator;
        private int currentClassIndex = 0;
        public frmModifyDeleteClass()
        {
            InitializeComponent();
            InitializeInfo();
            SetAllTextboxes(classes.First());
            createClassValidator = new CreateClassValidator();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifiy_Click(object sender, EventArgs e)
        {
            List<string> errorsStats = VerifyInfo();
            if (errorsStats.Count > 0)
            {
                ClassDetailsDTO newClass = new ClassDetailsDTO()
                {
                    NomClasse = nomClasseTextBox.Text,
                    Description = descriptionTextBox.Text,
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
                ClassDetailsDTO modifiedClass = new ClassDetailsDTO()
                {
                    Id = int.Parse(idTextBox.Text),
                    NomClasse = nomClasseTextBox.Text,
                    Description = descriptionTextBox.Text,
                    StatBaseStr = int.Parse(statBaseStrTextBox.Text),
                    StatBaseDex = int.Parse(statBaseDexTextBox.Text),
                    StatBaseInt = int.Parse(statBaseIntTextBox.Text),
                    StatBaseVitalite = int.Parse(statBaseVitaliteTextBox.Text)
                };

                var result = createClassValidator.Validate(modifiedClass);

                if (!result.IsValid)
                {
                    MessageBox.Show(string.Join("\n", result.Errors.ToList()), "Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        classServiceClient.SaveClass(modifiedClass);
                        MessageBox.Show("The user has been saved", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
                        InitializeInfo();
                        SetAllTextboxes(classes[currentClassIndex]);
                    }
                    catch
                    {
                        MessageBox.Show("An error has occured with the save of the user", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                DialogResult dir = MessageBox.Show("Are you sure you want to delete this hero?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                switch (dir)
                {
                    case DialogResult.Yes:
                    ClassDetailsDTO deletedClass = new ClassDetailsDTO()
                    {
                        Id = int.Parse(idTextBox.Text),
                    };
                    classServiceClient.DeleteClass(deletedClass);
                    InitializeInfo();
                    SetAllTextboxes(classes.First());
                    currentClassIndex = 0;
                    break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            SetAllTextboxes(classes[0]);
            currentClassIndex = 0;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentClassIndex > 0)
            {
                currentClassIndex--;
                SetAllTextboxes(classes[currentClassIndex]);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentClassIndex < classes.Count() - 1)
            {
                currentClassIndex++;
                SetAllTextboxes(classes[currentClassIndex]);
            }

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentClassIndex = classes.Count() - 1;
            SetAllTextboxes(classes[currentClassIndex]);

        }
        private void InitializeInfo()
        {
            try
            {
                classes = classServiceClient.GetAllClasses().ToList();
            }
            catch
            {
                MessageBox.Show("No classes have been found or a network error has occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void SetAllTextboxes(ClassDetailsDTO currentClass)
        {
            idTextBox.Text = currentClass.Id.ToString();
            nomClasseTextBox.Text = currentClass.NomClasse;
            descriptionTextBox.Text = currentClass.Description;
            statBaseStrTextBox.Text = currentClass.StatBaseStr.ToString();
            statBaseDexTextBox.Text = currentClass.StatBaseDex.ToString();
            statBaseIntTextBox.Text = currentClass.StatBaseInt.ToString();
            statBaseVitaliteTextBox.Text = currentClass.StatBaseVitalite.ToString();
        }

        private List<string> VerifyInfo()
        {
            List<string> errors = new List<string>();
            //Stats
            int StatStr, StatDex, StatInt, StatVitality;
            bool isNumericStr = int.TryParse(statBaseStrTextBox.Text, out StatStr);
            bool isNumericDex = int.TryParse(statBaseDexTextBox.Text, out StatDex);
            bool isNumericInt = int.TryParse(statBaseIntTextBox.Text, out StatInt);
            bool isNumericVitality = int.TryParse(statBaseVitaliteTextBox.Text, out StatVitality);
            if (!isNumericStr || StatStr < 0 || StatStr > 10)
                errors.Add("Please provide a valid base stat str between(inclusive) 0 and 10.");
            if (!isNumericDex || StatDex < 0 || StatDex > 10)
                errors.Add("Please provide a valid base stat dex between(inclusive) 0 and 10.");
            if (!isNumericInt || StatInt < 0 || StatInt > 10)
                errors.Add("Please provide a valid base stat int between(inclusive) 0 and 10.");
            if (!isNumericVitality || StatVitality < 0 || StatVitality > 10)
                errors.Add("Please provide a valid base stat vitality between(inclusive) 0 and 10.");

            return errors;
        }
    }
}
