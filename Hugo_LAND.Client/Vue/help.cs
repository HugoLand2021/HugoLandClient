using System;
using System.Windows.Forms;

namespace Hugo_LAND.Client
{
    public partial class helpform : Form
    {
        public helpform()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}