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
        private readonly AccountServiceClient accountService = new AccountServiceClient();
        private readonly frmLogin loginForm;
        public  AccountDetailsDTO accountDetails = new AccountDetailsDTO();

        internal void ConnectionReussie()
        {
            loginForm.Dispose();
            lblUsername.Text = accountDetails.NomJoueur;
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

        private void btnHero_Click(object sender, EventArgs e)
        {
            frmManageHero f = new frmManageHero(this);
            f.ShowDialog(this);
        }
    }
}
