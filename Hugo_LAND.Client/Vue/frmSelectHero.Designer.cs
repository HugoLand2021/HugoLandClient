
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
            this.btnBack = new System.Windows.Forms.Button();
            nomHeroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heroDetailsDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomHeroLabel
            // 
            nomHeroLabel.AutoSize = true;
            nomHeroLabel.Location = new System.Drawing.Point(20, 93);
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
            this.cmbNomhero.FormattingEnabled = true;
            this.cmbNomhero.Location = new System.Drawing.Point(84, 90);
            this.cmbNomhero.Name = "cmbNomhero";
            this.cmbNomhero.Size = new System.Drawing.Size(158, 21);
            this.cmbNomhero.TabIndex = 2;
            // 
            // lblnomCompte
            // 
            this.lblnomCompte.AutoSize = true;
            this.lblnomCompte.Font = new System.Drawing.Font("Old English Text MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomCompte.ForeColor = System.Drawing.Color.Red;
            this.lblnomCompte.Location = new System.Drawing.Point(100, 9);
            this.lblnomCompte.Name = "lblnomCompte";
            this.lblnomCompte.Size = new System.Drawing.Size(123, 26);
            this.lblnomCompte.TabIndex = 3;
            this.lblnomCompte.Text = "Nom compte";
            // 
            // btnJouerSelectHero
            // 
            this.btnJouerSelectHero.Font = new System.Drawing.Font("Old English Text MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJouerSelectHero.Location = new System.Drawing.Point(73, 133);
            this.btnJouerSelectHero.Name = "btnJouerSelectHero";
            this.btnJouerSelectHero.Size = new System.Drawing.Size(129, 47);
            this.btnJouerSelectHero.TabIndex = 4;
            this.btnJouerSelectHero.Text = "Play";
            this.btnJouerSelectHero.UseVisualStyleBackColor = true;
            this.btnJouerSelectHero.Click += new System.EventHandler(this.btnJouerSelectHero_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBack.Location = new System.Drawing.Point(0, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 57);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "🠔";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmSelectHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 203);
            this.Controls.Add(this.btnBack);
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
        private System.Windows.Forms.Button btnBack;
    }
}