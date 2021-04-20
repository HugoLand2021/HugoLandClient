using Hugo_LAND.Client.HugoLandServices;
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
    public partial class frmDeleteHero : Form
    {
        private string nomCompte;
        private int id;
        private readonly HeroServiceClient HeroService = new HeroServiceClient();
        private List<HeroDetailsDTO> herosList = new List<HeroDetailsDTO>();

        public frmDeleteHero(frmMain main)
        {
            InitializeComponent();
            nomCompte = main.accountDetails.PlayerName;
            id = main.accountDetails.Id;
            try
            {
                herosList = HeroService.ReturnHerosFromAccount(id).ToList();
            }
            catch 
            {

            }
            if (herosList.Count() == 0)
            {
                MessageBox.Show("This account doesn't have any hero or there has been a network error.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbNomHero.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                cmbNomHero.DataSource = herosList.Select(e => e.HeroName).ToList();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbNomHero != null)
            {
                DialogResult dir = MessageBox.Show("Are you sure you want to delete this hero?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (dir)
                {
                    case DialogResult.Yes:
                        bool isSuccess = HeroService.DeleteHero(herosList[cmbNomHero.SelectedIndex]);
                        if (isSuccess)
                        {
                            MessageBox.Show("The hero has been deleted", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
                            this.Close();
                        }
                        else
                            MessageBox.Show("An error has occured while trying to delete the hero", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
