using Hugo_LAND.Client.Services;
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
    public partial class frmLogin : Form
    {
        private bool EstConnecte = false;
        private readonly frmMain mainForm;
        public string name = "";
        private readonly CompteJoueurServiceClient compteJoueurService = new CompteJoueurServiceClient();


        public frmLogin(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            txtPwd.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Resultat = compteJoueurService.ConnexionUtilisateur(txtUserName.Text, txtPwd.Text);
            if (Resultat == "SUCCESS")
            {
                EstConnecte = true;
                name = txtUserName.Text;
                mainForm.ConnectionReussie();
                this.Close();
            }
            else if (Resultat == "NETWORKERROR")
                MessageBox.Show("A network error has occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("The username or password is incorrect!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        private void btnCancel_Click(object sender, EventArgs e) => Application.Exit();

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!EstConnecte)
                Application.Exit();
        }
    }
}
