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
    public partial class frmMain : Form
    {
        private readonly AccountServiceClient compteJoueurService = new AccountServiceClient();
        private readonly frmLogin loginForm;
        public string nom = "";
        public int id = 0;

        internal void ConnectionReussie()
        {
            loginForm.Dispose();
            lblUsername.Text = loginForm.name;
            nom = loginForm.name;
            id = compteJoueurService.RetourneIdCompteParNom(nom);
            this.Enabled = true;
        }

        public frmMain()
        {
            InitializeComponent();
            loginForm = new frmLogin(this);
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;
            loginForm.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            frmSelectHero selecthero = new frmSelectHero(this);
            selecthero.ShowDialog();
            //HugoWorld hugoWorld = new HugoWorld(this);
            //hugoWorld.ShowDialog();

        }

        private void btnClassManagement_Click(object sender, EventArgs e)
        {
            frmClassManager f = new frmClassManager();
            f.ShowDialog(this);
        }
    }
}
