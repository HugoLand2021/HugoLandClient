using Hugo_LAND.Client.HugoLandServices;
using System;
using System.Windows.Forms;

namespace Hugo_LAND.Client.Vue
{
    public partial class frmMain : Form
    {
        private readonly AccountServiceClient accountService = new AccountServiceClient();
        private readonly HeroServiceClient heroService = new HeroServiceClient();
        private readonly frmLogin loginForm;
        private HeroDetailsDTO hero;
        public AccountDetailsDTO accountDetails = new AccountDetailsDTO();

        internal void SuccessfulConnection()
        {
            loginForm.Dispose();
            lblUsername.Text = accountDetails.PlayerName;
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
            if (accountDetails.TypeUtilisateur.ToString() == "Admin")
            {
                btnClassManagement.Enabled = true;
                btnClassManagement.Visible = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmSelectHero selecthero = new frmSelectHero(this);
            selecthero.ShowDialog(this);
            hero = selecthero.selectedHero;

            if (hero is object)
            {
                    HugoWorld hugoWorld = new HugoWorld(hero);
                    hugoWorld.ShowDialog();
                    //heroService.DisconnectHero(hero.Id, false);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            heroService.DisconnectHero(33, false);
        }
    }
}
