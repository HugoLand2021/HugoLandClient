using System;
using System.Windows.Forms;

namespace Hugo_LAND.Client.Vue
{
    public partial class frmClassManager : Form
    {
        public frmClassManager()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            frmCreateClass f = new frmCreateClass();
            f.ShowDialog(this);
        }

        private void btnModifyDeleteClass_Click(object sender, EventArgs e)
        {
            frmModifyDeleteClass f = new frmModifyDeleteClass();
            f.ShowDialog(this);
        }
    }
}
