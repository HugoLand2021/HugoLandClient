
namespace Hugo_LAND.Client.Vue
{
    partial class frmSelectHero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomHeroLabel;
            this.heroDetailsDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbNomhero = new System.Windows.Forms.ComboBox();
            this.lblnomCompte = new System.Windows.Forms.Label();
            this.btnJouerSelectHero = new System.Windows.Forms.Button();
            nomHeroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heroDetailsDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomHeroLabel
            // 
            nomHeroLabel.AutoSize = true;
            nomHeroLabel.Location = new System.Drawing.Point(69, 76);
            nomHeroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomHeroLabel.Name = "nomHeroLabel";
            nomHeroLabel.Size = new System.Drawing.Size(76, 17);
            nomHeroLabel.TabIndex = 1;
            nomHeroLabel.Text = "Nom Hero:";
            // 
            // heroDetailsDTOBindingSource
            // 
            this.heroDetailsDTOBindingSource.DataSource = typeof(Hugo_LAND.Client.HugoLandServices.HeroDetailsDTO);
            // 
            // cmbNomhero
            // 
            this.cmbNomhero.FormattingEnabled = true;
            this.cmbNomhero.Location = new System.Drawing.Point(155, 73);
            this.cmbNomhero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNomhero.Name = "cmbNomhero";
            this.cmbNomhero.Size = new System.Drawing.Size(160, 24);
            this.cmbNomhero.TabIndex = 2;
            // 
            // lblnomCompte
            // 
            this.lblnomCompte.AutoSize = true;
            this.lblnomCompte.Font = new System.Drawing.Font("Old English Text MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomCompte.ForeColor = System.Drawing.Color.Red;
            this.lblnomCompte.Location = new System.Drawing.Point(67, 11);
            this.lblnomCompte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnomCompte.Name = "lblnomCompte";
            this.lblnomCompte.Size = new System.Drawing.Size(163, 32);
            this.lblnomCompte.TabIndex = 3;
            this.lblnomCompte.Text = "Nom compte";
            // 
            // btnJouerSelectHero
            // 
            this.btnJouerSelectHero.Location = new System.Drawing.Point(140, 126);
            this.btnJouerSelectHero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJouerSelectHero.Name = "btnJouerSelectHero";
            this.btnJouerSelectHero.Size = new System.Drawing.Size(115, 28);
            this.btnJouerSelectHero.TabIndex = 4;
            this.btnJouerSelectHero.Text = "Play";
            this.btnJouerSelectHero.UseVisualStyleBackColor = true;
            this.btnJouerSelectHero.Click += new System.EventHandler(this.btnJouerSelectHero_Click);
            // 
            // frmSelectHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 169);
            this.Controls.Add(this.btnJouerSelectHero);
            this.Controls.Add(this.lblnomCompte);
            this.Controls.Add(nomHeroLabel);
            this.Controls.Add(this.cmbNomhero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSelectHero";
            this.Text = "Select Hero";
            ((System.ComponentModel.ISupportInitialize)(this.heroDetailsDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource heroDetailsDTOBindingSource;
        private System.Windows.Forms.ComboBox cmbNomhero;
        private System.Windows.Forms.Label lblnomCompte;
        private System.Windows.Forms.Button btnJouerSelectHero;
    }
}