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
        private readonly AccountServiceClient compteJoueurService = new AccountServiceClient();
        private readonly WorldServiceClient worldServiceClient = new WorldServiceClient();
        private readonly ClassServiceClient classServiceClient = new ClassServiceClient();
        private readonly List<WorldItemDTO> worldsList = new List<WorldItemDTO>();
        private readonly List<ClassDetailsDTO> classList = new List<ClassDetailsDTO>();

        public frmCreateHero(frmMain main)
        {
            InitializeComponent();
            nomCompte = main.nom;
            worldsList = worldServiceClient.GetAllWorldNames().ToList();
            classList = classServiceClient.GetClasse().ToList();
            cmbDescription.DataSource = worldsList.Select(w => w.Description).ToList();
            cmbNomClass.DataSource = classList.Select(c => c.NomClasse).ToList();
        }

        private void btnCreateHeroFrm_Click(object sender, EventArgs e)
        {
            var user = compteJoueurService.RetourneIdCompteParNom(nomCompte);
            var classe = classServiceClient.GetClasseByName(cmbNomClass.Text);
            var monde = worldServiceClient.GetWorldByName(cmbDescription.Text);

            HeroService.CreeHero(txtnomHero.Text, false, classe.Id, user, monde.Id);
        }

        private void btnCancelHeroFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
