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
        private readonly HeroServiceClient HeroService = new HeroServiceClient();
        private readonly AccountServiceClient compteJoueurService = new AccountServiceClient();

        public frmDeleteHero(frmMain main)
        {
            InitializeComponent();
            nomCompte = main.nom;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            var user = compteJoueurService.RetourneIdCompteParNom(nomCompte);
            //var currhero = HeroService.RetourneHerosActuel(txtidHero.Text);
            //HeroService.SupprimeHero(currhero);


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
