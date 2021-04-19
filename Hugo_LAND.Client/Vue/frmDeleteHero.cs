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
            nomCompte = main.nom;
            id = main.id;
            herosList = HeroService.RetourneHerosCompte(id).ToList();

            if (herosList.Count() == 0)
            {
                MessageBox.Show("This account dosn't have any hero.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbNomHero.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                cmbNomHero.DataSource = herosList.Select(e => e.NomHero).ToList();
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
                        HeroService.SupprimeHero(herosList[cmbNomHero.SelectedIndex]);
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }

            //var currhero = HeroService.RetourneHerosActuel(txtidHero.Text);
            //HeroService.SupprimeHero(currhero);


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
