
namespace Hugo_LAND.Client.Vue
{
    partial class frmCreateHero
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
            System.Windows.Forms.Label statBaseDexLabel;
            System.Windows.Forms.Label statBaseRegLabel;
            System.Windows.Forms.Label statBaseStrLabel;
            System.Windows.Forms.Label statBaseVitaliteLabel;
            System.Windows.Forms.Label lblMonde;
            System.Windows.Forms.Label lblNomClasse;
            this.txtnomHero = new System.Windows.Forms.TextBox();
            this.txtstatBaseDex = new System.Windows.Forms.TextBox();
            this.txtstatBaseReg = new System.Windows.Forms.TextBox();
            this.txtstatBaseStr = new System.Windows.Forms.TextBox();
            this.txtstatBaseVitalite = new System.Windows.Forms.TextBox();
            this.btnCreateHeroFrm = new System.Windows.Forms.Button();
            this.lblCreate = new System.Windows.Forms.Label();
            this.cmbDescription = new System.Windows.Forms.ComboBox();
            this.cmbNomClass = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.heroDetailsDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nomHeroLabel = new System.Windows.Forms.Label();
            statBaseDexLabel = new System.Windows.Forms.Label();
            statBaseRegLabel = new System.Windows.Forms.Label();
            statBaseStrLabel = new System.Windows.Forms.Label();
            statBaseVitaliteLabel = new System.Windows.Forms.Label();
            lblMonde = new System.Windows.Forms.Label();
            lblNomClasse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heroDetailsDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomHeroLabel
            // 
            nomHeroLabel.AutoSize = true;
            nomHeroLabel.Location = new System.Drawing.Point(16, 86);
            nomHeroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomHeroLabel.Name = "nomHeroLabel";
            nomHeroLabel.Size = new System.Drawing.Size(84, 17);
            nomHeroLabel.TabIndex = 9;
            nomHeroLabel.Text = "Hero Name:";
            // 
            // statBaseDexLabel
            // 
            statBaseDexLabel.AutoSize = true;
            statBaseDexLabel.Location = new System.Drawing.Point(16, 150);
            statBaseDexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            statBaseDexLabel.Name = "statBaseDexLabel";
            statBaseDexLabel.Size = new System.Drawing.Size(101, 17);
            statBaseDexLabel.TabIndex = 29;
            statBaseDexLabel.Text = "Stat Base Dex:";
            // 
            // statBaseRegLabel
            // 
            statBaseRegLabel.AutoSize = true;
            statBaseRegLabel.Location = new System.Drawing.Point(16, 182);
            statBaseRegLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            statBaseRegLabel.Name = "statBaseRegLabel";
            statBaseRegLabel.Size = new System.Drawing.Size(119, 17);
            statBaseRegLabel.TabIndex = 31;
            statBaseRegLabel.Text = "Stat Base Regen:";
            // 
            // statBaseStrLabel
            // 
            statBaseStrLabel.AutoSize = true;
            statBaseStrLabel.Location = new System.Drawing.Point(16, 214);
            statBaseStrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            statBaseStrLabel.Name = "statBaseStrLabel";
            statBaseStrLabel.Size = new System.Drawing.Size(95, 17);
            statBaseStrLabel.TabIndex = 33;
            statBaseStrLabel.Text = "Stat Base Str:";
            // 
            // statBaseVitaliteLabel
            // 
            statBaseVitaliteLabel.AutoSize = true;
            statBaseVitaliteLabel.Location = new System.Drawing.Point(16, 246);
            statBaseVitaliteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            statBaseVitaliteLabel.Name = "statBaseVitaliteLabel";
            statBaseVitaliteLabel.Size = new System.Drawing.Size(118, 17);
            statBaseVitaliteLabel.TabIndex = 35;
            statBaseVitaliteLabel.Text = "Stat Base Vitality:";
            // 
            // lblMonde
            // 
            lblMonde.AutoSize = true;
            lblMonde.Location = new System.Drawing.Point(16, 278);
            lblMonde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMonde.Name = "lblMonde";
            lblMonde.Size = new System.Drawing.Size(49, 17);
            lblMonde.TabIndex = 43;
            lblMonde.Text = "World:";
            // 
            // lblNomClasse
            // 
            lblNomClasse.AutoSize = true;
            lblNomClasse.Location = new System.Drawing.Point(16, 117);
            lblNomClasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNomClasse.Name = "lblNomClasse";
            lblNomClasse.Size = new System.Drawing.Size(87, 17);
            lblNomClasse.TabIndex = 44;
            lblNomClasse.Text = "Nom Classe:";
            // 
            // txtnomHero
            // 
            this.txtnomHero.Location = new System.Drawing.Point(144, 82);
            this.txtnomHero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnomHero.Name = "txtnomHero";
            this.txtnomHero.Size = new System.Drawing.Size(351, 22);
            this.txtnomHero.TabIndex = 10;
            // 
            // txtstatBaseDex
            // 
            this.txtstatBaseDex.Location = new System.Drawing.Point(144, 146);
            this.txtstatBaseDex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtstatBaseDex.Name = "txtstatBaseDex";
            this.txtstatBaseDex.ReadOnly = true;
            this.txtstatBaseDex.Size = new System.Drawing.Size(351, 22);
            this.txtstatBaseDex.TabIndex = 30;
            // 
            // txtstatBaseReg
            // 
            this.txtstatBaseReg.Location = new System.Drawing.Point(144, 178);
            this.txtstatBaseReg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtstatBaseReg.Name = "txtstatBaseReg";
            this.txtstatBaseReg.ReadOnly = true;
            this.txtstatBaseReg.Size = new System.Drawing.Size(351, 22);
            this.txtstatBaseReg.TabIndex = 32;
            // 
            // txtstatBaseStr
            // 
            this.txtstatBaseStr.Location = new System.Drawing.Point(144, 210);
            this.txtstatBaseStr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtstatBaseStr.Name = "txtstatBaseStr";
            this.txtstatBaseStr.ReadOnly = true;
            this.txtstatBaseStr.Size = new System.Drawing.Size(351, 22);
            this.txtstatBaseStr.TabIndex = 34;
            // 
            // txtstatBaseVitalite
            // 
            this.txtstatBaseVitalite.Location = new System.Drawing.Point(144, 242);
            this.txtstatBaseVitalite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtstatBaseVitalite.Name = "txtstatBaseVitalite";
            this.txtstatBaseVitalite.ReadOnly = true;
            this.txtstatBaseVitalite.Size = new System.Drawing.Size(351, 22);
            this.txtstatBaseVitalite.TabIndex = 36;
            // 
            // btnCreateHeroFrm
            // 
            this.btnCreateHeroFrm.Font = new System.Drawing.Font("Old English Text MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateHeroFrm.Location = new System.Drawing.Point(97, 341);
            this.btnCreateHeroFrm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateHeroFrm.Name = "btnCreateHeroFrm";
            this.btnCreateHeroFrm.Size = new System.Drawing.Size(149, 46);
            this.btnCreateHeroFrm.TabIndex = 41;
            this.btnCreateHeroFrm.Text = "Create";
            this.btnCreateHeroFrm.UseVisualStyleBackColor = true;
            this.btnCreateHeroFrm.Click += new System.EventHandler(this.btnCreateHeroFrm_Click);
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Old English Text MT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreate.Location = new System.Drawing.Point(119, 11);
            this.lblCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(286, 53);
            this.lblCreate.TabIndex = 43;
            this.lblCreate.Text = "Create a Hero";
            // 
            // cmbDescription
            // 
            this.cmbDescription.FormattingEnabled = true;
            this.cmbDescription.Location = new System.Drawing.Point(144, 274);
            this.cmbDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDescription.Name = "cmbDescription";
            this.cmbDescription.Size = new System.Drawing.Size(351, 24);
            this.cmbDescription.TabIndex = 44;
            // 
            // cmbNomClass
            // 
            this.cmbNomClass.FormattingEnabled = true;
            this.cmbNomClass.Location = new System.Drawing.Point(144, 113);
            this.cmbNomClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNomClass.Name = "cmbNomClass";
            this.cmbNomClass.Size = new System.Drawing.Size(351, 24);
            this.cmbNomClass.TabIndex = 45;
            this.cmbNomClass.SelectedIndexChanged += new System.EventHandler(this.cmbNomClass_SelectedIndexChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Old English Text MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(267, 341);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(149, 46);
            this.btnGenerate.TabIndex = 46;
            this.btnGenerate.Text = "Generate again";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
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
            this.btnBack.Location = new System.Drawing.Point(1, 1);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 70);
            this.btnBack.TabIndex = 47;
            this.btnBack.Text = "🠔";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // heroDetailsDTOBindingSource
            // 
            this.heroDetailsDTOBindingSource.DataSource = typeof(Hugo_LAND.Client.HugoLandServices.HeroDetailsDTO);
            // 
            // frmCreateHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 416);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(lblNomClasse);
            this.Controls.Add(this.cmbNomClass);
            this.Controls.Add(lblMonde);
            this.Controls.Add(this.cmbDescription);
            this.Controls.Add(this.lblCreate);
            this.Controls.Add(this.btnCreateHeroFrm);
            this.Controls.Add(statBaseDexLabel);
            this.Controls.Add(this.txtstatBaseDex);
            this.Controls.Add(statBaseRegLabel);
            this.Controls.Add(this.txtstatBaseReg);
            this.Controls.Add(statBaseStrLabel);
            this.Controls.Add(this.txtstatBaseStr);
            this.Controls.Add(statBaseVitaliteLabel);
            this.Controls.Add(this.txtstatBaseVitalite);
            this.Controls.Add(nomHeroLabel);
            this.Controls.Add(this.txtnomHero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCreateHero";
            this.Text = "Create Hero";
            ((System.ComponentModel.ISupportInitialize)(this.heroDetailsDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource heroDetailsDTOBindingSource;
        private System.Windows.Forms.TextBox txtnomHero;
        private System.Windows.Forms.TextBox txtstatBaseDex;
        private System.Windows.Forms.TextBox txtstatBaseReg;
        private System.Windows.Forms.TextBox txtstatBaseStr;
        private System.Windows.Forms.TextBox txtstatBaseVitalite;
        private System.Windows.Forms.Button btnCreateHeroFrm;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.ComboBox cmbDescription;
        private System.Windows.Forms.ComboBox cmbNomClass;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnBack;
    }
}