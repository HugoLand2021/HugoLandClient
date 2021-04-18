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
    public partial class frmCreateClass : Form
    {
        private readonly WorldServiceClient worldServiceClient = new WorldServiceClient();
        private readonly ClassServiceClient classServiceClient = new ClassServiceClient();
        private readonly List<WorldItemDTO> worldsList = new List<WorldItemDTO>();

        public frmCreateClass()
        {
            InitializeComponent();
            worldsList = worldServiceClient.GetAllWorldNames().ToList();
            comboWorlds.DataSource = worldsList.Select(w => w.Description).ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //FAIRE VALIDATION FLUENT 

            ClassDetailsDTO newClass = new ClassDetailsDTO() {
                NomClasse = txtName.Text,
                Description = txtDescription.Text,
                StatBaseStr = int.Parse(txtStr.Text),
                StatBaseDex = int.Parse(txtDex.Text),
                StatBaseInt = int.Parse(txtInt.Text),
                StatBaseVitalite = int.Parse(txtVitality.Text)
            };
            WorldItemDTO world = worldsList.FirstOrDefault(w => w.Description == comboWorlds.Text);
            classServiceClient.CreerClasse(newClass, world);
        }
    }
}
