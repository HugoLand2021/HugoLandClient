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
    public partial class frmSelectHero : Form
    {
        private string nom;
        private int id;
        private List<HeroDetailsDTO> herosList = new List<HeroDetailsDTO>();
        private readonly HeroServiceClient HeroService = new HeroServiceClient();
        public frmSelectHero(frmMain main)
        {
            InitializeComponent();
            nom = main.nom;
            id = main.id;
            lblnomCompte.Text = nom;
            var list = HeroService.RetourneHerosCompte(id);


            herosList = HeroService.RetourneHerosCompte(id).ToList();
            if (herosList.Count() == 0)
            {
                MessageBox.Show("This account dosn't have any hero.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbNomhero.Enabled = false;
                btnJouerSelectHero.Enabled = false;
            }
            else
            {
                
                cmbNomhero.DataSource = herosList.Select(e => e.NomHero).ToList();
            }
        }

        private void btnJouerSelectHero_Click(object sender, EventArgs e)
        {
            if (cmbNomhero != null)
            {
                HugoWorld hugoWorld = new HugoWorld(this);
                hugoWorld.ShowDialog();
            }

        }
    }
}
