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
        bool _HeroSelected = false;
        private readonly HeroServiceClient HeroService = new HeroServiceClient();
        private readonly frmMain _main;
        public frmSelectHero(frmMain main)
        {
            _main = main;
            InitializeComponent();
            lblnomCompte.Text = _main.accountDetails.PlayerName;
            var list = HeroService.ReturnHerosFromAccount(_main.accountDetails.Id);


            try
            {
                herosList = HeroService.ReturnHerosFromAccount(_main.accountDetails.Id).ToList();
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
                    if (!HeroService.IsHeroConnected(cmbNomhero.Text, _main.accountDetails.Id))
                    {
                        selectedHero = herosList[cmbNomhero.SelectedIndex];
                        _HeroSelected = true;
                    }
                    else
                    {
                        MessageBox.Show("This hero is already in game!", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }

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
            this.Close();
        }

        private void frmSelectHero_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_HeroSelected)
                selectedHero = null;
        }
    }
}
