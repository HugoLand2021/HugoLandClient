using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugoWorld.Vue
{
    public partial class frmMain : Form
    {
        private readonly frmLogin loginForm;

        internal void ConnectionReussie()
        {
            loginForm.Dispose();
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
    }
}
