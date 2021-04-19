
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
            nomHeroLabel.Location = new System.Drawing.Point(52, 62);
            nomHeroLabel.Name = "nomHeroLabel";
            nomHeroLabel.Size = new System.Drawing.Size(58, 13);
            nomHeroLabel.TabIndex = 1;
            nomHeroLabel.Text = "Nom Hero:";
            // 
            // heroDetailsDTOBindingSource
            // 
            this.heroDetailsDTOBindingSource.DataSource = typeof(Hugo_LAND.Client.HugoLandServices.HeroDetailsDTO);
            // 
            // cmbNomhero
            // 
            this.cmbNomhero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "NomHero", true));
            this.cmbNomhero.FormattingEnabled = true;
            this.cmbNomhero.Location = new System.Drawing.Point(116, 59);
            this.cmbNomhero.Name = "cmbNomhero";
            this.cmbNomhero.Size = new System.Drawing.Size(121, 21);
            this.cmbNomhero.TabIndex = 2;
            // 
            // lblnomCompte
            // 
            this.lblnomCompte.AutoSize = true;
            this.lblnomCompte.Font = new System.Drawing.Font("Old English Text MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomCompte.ForeColor = System.Drawing.Color.Red;
            this.lblnomCompte.Location = new System.Drawing.Point(50, 9);
            this.lblnomCompte.Name = "lblnomCompte";
            this.lblnomCompte.Size = new System.Drawing.Size(123, 26);
            this.lblnomCompte.TabIndex = 3;
            this.lblnomCompte.Text = "Nom compte";
            // 
            // btnJouerSelectHero
            // 
            this.btnJouerSelectHero.Location = new System.Drawing.Point(105, 102);
            this.btnJouerSelectHero.Name = "btnJouerSelectHero";
            this.btnJouerSelectHero.Size = new System.Drawing.Size(86, 23);
            this.btnJouerSelectHero.TabIndex = 4;
            this.btnJouerSelectHero.Text = "Play";
            this.btnJouerSelectHero.UseVisualStyleBackColor = true;
            this.btnJouerSelectHero.Click += new System.EventHandler(this.btnJouerSelectHero_Click);
            // 
            // frmSelectHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 137);
            this.Controls.Add(this.btnJouerSelectHero);
            this.Controls.Add(this.lblnomCompte);
            this.Controls.Add(nomHeroLabel);
            this.Controls.Add(this.cmbNomhero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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