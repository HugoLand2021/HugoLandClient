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
    public partial class frmCreateHero : Form
    {
        private string nomCompte;
        private readonly HeroServiceClient HeroService = new HeroServiceClient();
        //private readonly 
        private readonly AccountServiceClient compteJoueurService = new AccountServiceClient();

        public frmCreateHero(frmMain main)
        {
            InitializeComponent();
            nomCompte = main.nom;
        }

        private void btnCreateHeroFrm_Click(object sender, EventArgs e)
        {
            var user = compteJoueurService.RetourneIdCompteParNom(nomCompte);
            
            HeroService.CreeHero(txtnomHero, false, txtidClasse, user, txtidMonde);
        }

        private void btnCancelHeroFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
