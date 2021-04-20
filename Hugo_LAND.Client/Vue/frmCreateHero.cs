using Hugo_LAND.Client.HugoLandServices;
using Hugo_LAND.Client.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Hugo_LAND.Client.Vue
{
    public partial class frmCreateHero : Form
    {
        private readonly Random _random = new Random();
        private string nomCompte;
        private readonly HeroServiceClient HeroService = new HeroServiceClient();
        private readonly WorldServiceClient worldServiceClient = new WorldServiceClient();
        private readonly ClassServiceClient classServiceClient = new ClassServiceClient();
        private List<WorldDetailsDTO> worldsList = new List<WorldDetailsDTO>();
        private List<ClassDetailsDTO> classList = new List<ClassDetailsDTO>();
        private readonly CreateHeroValidator createHeroValidator;


        public frmCreateHero(frmMain main)
        {
            InitializeComponent();
            nomCompte = main.accountDetails.PlayerName;
            createHeroValidator = new CreateHeroValidator();
            LoadWorlds();
            LoadClasses();
            UpdateStats();
        }

        private void btnCreateHeroFrm_Click(object sender, EventArgs e)
        {
            List<string> errors = VerifyInfo();
            HeroDetailsDTO hero = new HeroDetailsDTO()
            {
                HeroName = txtnomHero.Text,
                StatDex = int.Parse(txtstatBaseDex.Text),
                StatInt = int.Parse(txtstatBaseInt.Text),
                StatStr = int.Parse(txtstatBaseStr.Text),
                StatVitality = int.Parse(txtstatBaseVitalite.Text),
                Class = cmbNomClass.Text,
                World = cmbDescription.Text,
                UserName = nomCompte
            };
            var result = createHeroValidator.Validate(hero);
            foreach (var item in result.Errors)
                errors.Add(item.ErrorMessage);
            if (errors.Count() > 0)
                MessageBox.Show(string.Join("\n", errors), "Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                bool isSuccess = HeroService.CreateHero(hero);
                if (isSuccess)
                {
                    MessageBox.Show("The hero has been created", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
                else
                    MessageBox.Show("An error has occured with the creation of the hero", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelHeroFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateStats()
        {
            try
            {
                var currClass = classList[cmbNomClass.SelectedIndex];
                txtstatBaseDex.Text = (currClass.StatBaseDex + _random.Next(0, 11)).ToString();
                txtstatBaseInt.Text = (currClass.StatBaseInt + _random.Next(0, 11)).ToString(); ;
                txtstatBaseStr.Text = (currClass.StatBaseStr + _random.Next(0, 11)).ToString(); ;
                txtstatBaseVitalite.Text = (currClass.StatBaseVitality + _random.Next(0, 11)).ToString(); ;
            }
            catch
            {

            }
        }

        private void cmbNomClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStats();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            UpdateStats();
        }
        private void LoadWorlds()
        {
            try
            {
                worldsList = worldServiceClient.GetAllWorldNames().ToList();
                cmbDescription.DataSource = worldsList.Select(w => w.Description).ToList();
            }
            catch
            {
                MessageBox.Show("No worlds have been found or a network error has occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DisableComponents();
            }
        }
        private void LoadClasses()
        {
            try
            {
                classList = classServiceClient.GetAllClasses().ToList();
                cmbNomClass.DataSource = classList.Select(c => c.ClassName).ToList();

            }
            catch
            {
                MessageBox.Show("No classes have been found or a network error has occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DisableComponents();
            }
        }
        List<string> VerifyInfo()
        {
            List<string> errors = new List<string>();

            //Class
            ClassDetailsDTO c;
            try
            {
                c = classList.First(cl => cl.ClassName == cmbNomClass.Text);
            }
            catch
            {
                c = null;
            }
            if (string.IsNullOrEmpty(cmbDescription.Text) || c == null)
                errors.Add("Please select a valid class.");

            //World
            WorldDetailsDTO w;
            try
            {
                w = worldsList.First(wo => wo.Description == cmbDescription.Text);
            }
            catch
            {
                w = null;
            }
            if (string.IsNullOrEmpty(cmbDescription.Text) || w == null)
                errors.Add("Please select a valid world.");

            return errors;
        }
        void DisableComponents()
        {
            btnGenerate.Enabled = false;
            btnCreateHeroFrm.Enabled = false;
            txtnomHero.Enabled = false;
            cmbDescription.Enabled = false;
            cmbNomClass.Enabled = false;
            txtstatBaseStr.Enabled = false;
            txtstatBaseDex.Enabled = false;
            txtstatBaseInt.Enabled = false;
            txtstatBaseVitalite.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
