using Hugo_LAND.Client.HugoLandServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Hugo_LAND.Client.Vue
{
    public partial class frmSelectHero : Form
    {

        private List<HeroDetailsDTO> herosList = new List<HeroDetailsDTO>();
        public HeroDetailsDTO selectedHero = new HeroDetailsDTO();
        private readonly HeroServiceClient HeroService = new HeroServiceClient();
        public frmSelectHero(frmMain main)
        {
            InitializeComponent();
            lblnomCompte.Text = main.accountDetails.PlayerName;
            var list = HeroService.ReturnHerosFromAccount(main.accountDetails.Id);


            try
            {
                herosList = HeroService.ReturnHerosFromAccount(main.accountDetails.Id).ToList();

            }
            catch
            {

            }
            if (herosList.Count() == 0)
            {
                MessageBox.Show("This account doesn't have any heros or there has been a network error.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbNomhero.Enabled = false;
                btnJouerSelectHero.Enabled = false;
            }
            else
            {

                cmbNomhero.DataSource = herosList.Select(e => e.HeroName).ToList();
            }
        }

        private void btnJouerSelectHero_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (cmbNomhero.Text != "")
            {
                if (herosList.Any(h => h.HeroName == cmbNomhero.Text))
                {
                    selectedHero = herosList[cmbNomhero.SelectedIndex];
                    
                    this.Close();
                }
                else
                    error = true;
            }
            else
                error = true;
            if (error)
                MessageBox.Show("Please select a valid hero.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            selectedHero = null;
            this.Close();
        }
    }
}
