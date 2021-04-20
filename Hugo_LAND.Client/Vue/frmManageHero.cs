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
    public partial class frmManageHero : Form
    {
        private readonly frmMain mainForm;
        //private readonly frmCreateHero createHeroForm;
        //private readonly frmDeleteHero deleteHeroForm;


        public frmManageHero(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            //lblHeroManagement.Text = mainForm.nom;
        }

        private void btnCancelManagement_Click(object sender, EventArgs e)
        {
        }

        private void bntCreateHero_Click(object sender, EventArgs e)
        {
            frmCreateHero createHeroForm = new frmCreateHero(mainForm);
            createHeroForm.ShowDialog(this);

        }

        private void btnDeleteHero_Click(object sender, EventArgs e)
        {
            frmDeleteHero deleteHeroForm = new frmDeleteHero(mainForm);
            deleteHeroForm.ShowDialog(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
