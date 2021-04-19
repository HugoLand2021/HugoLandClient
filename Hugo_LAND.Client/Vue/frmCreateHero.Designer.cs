
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
            System.Windows.Forms.Label statBaseIntLabel;
            System.Windows.Forms.Label statBaseStrLabel;
            System.Windows.Forms.Label statBaseVitaliteLabel;
            System.Windows.Forms.Label lblMonde;
            System.Windows.Forms.Label lblNomClasse;
            this.txtnomHero = new System.Windows.Forms.TextBox();
            this.txtstatBaseDex = new System.Windows.Forms.TextBox();
            this.txtstatBaseInt = new System.Windows.Forms.TextBox();
            this.txtstatBaseStr = new System.Windows.Forms.TextBox();
            this.txtstatBaseVitalite = new System.Windows.Forms.TextBox();
            this.btnCreateHeroFrm = new System.Windows.Forms.Button();
            this.btnCancelHeroFrm = new System.Windows.Forms.Button();
            this.lblCreate = new System.Windows.Forms.Label();
            this.cmbDescription = new System.Windows.Forms.ComboBox();
            this.cmbNomClass = new System.Windows.Forms.ComboBox();
            this.heroDetailsDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nomHeroLabel = new System.Windows.Forms.Label();
            statBaseDexLabel = new System.Windows.Forms.Label();
            statBaseIntLabel = new System.Windows.Forms.Label();
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
            nomHeroLabel.Location = new System.Drawing.Point(12, 70);
            nomHeroLabel.Name = "nomHeroLabel";
            nomHeroLabel.Size = new System.Drawing.Size(62, 13);
            nomHeroLabel.TabIndex = 9;
            nomHeroLabel.Text = "Hero name:";
            // 
            // statBaseDexLabel
            // 
            statBaseDexLabel.AutoSize = true;
            statBaseDexLabel.Location = new System.Drawing.Point(12, 122);
            statBaseDexLabel.Name = "statBaseDexLabel";
            statBaseDexLabel.Size = new System.Drawing.Size(78, 13);
            statBaseDexLabel.TabIndex = 29;
            statBaseDexLabel.Text = "Stat Base Dex:";
            // 
            // statBaseIntLabel
            // 
            statBaseIntLabel.AutoSize = true;
            statBaseIntLabel.Location = new System.Drawing.Point(12, 148);
            statBaseIntLabel.Name = "statBaseIntLabel";
            statBaseIntLabel.Size = new System.Drawing.Size(71, 13);
            statBaseIntLabel.TabIndex = 31;
            statBaseIntLabel.Text = "Stat Base Int:";
            // 
            // statBaseStrLabel
            // 
            statBaseStrLabel.AutoSize = true;
            statBaseStrLabel.Location = new System.Drawing.Point(12, 174);
            statBaseStrLabel.Name = "statBaseStrLabel";
            statBaseStrLabel.Size = new System.Drawing.Size(72, 13);
            statBaseStrLabel.TabIndex = 33;
            statBaseStrLabel.Text = "Stat Base Str:";
            // 
            // statBaseVitaliteLabel
            // 
            statBaseVitaliteLabel.AutoSize = true;
            statBaseVitaliteLabel.Location = new System.Drawing.Point(12, 200);
            statBaseVitaliteLabel.Name = "statBaseVitaliteLabel";
            statBaseVitaliteLabel.Size = new System.Drawing.Size(90, 13);
            statBaseVitaliteLabel.TabIndex = 35;
            statBaseVitaliteLabel.Text = "Stat Base Vitalite:";
            // 
            // lblMonde
            // 
            lblMonde.AutoSize = true;
            lblMonde.Location = new System.Drawing.Point(12, 226);
            lblMonde.Name = "lblMonde";
            lblMonde.Size = new System.Drawing.Size(38, 13);
            lblMonde.TabIndex = 43;
            lblMonde.Text = "World:";
            // 
            // lblNomClasse
            // 
            lblNomClasse.AutoSize = true;
            lblNomClasse.Location = new System.Drawing.Point(12, 95);
            lblNomClasse.Name = "lblNomClasse";
            lblNomClasse.Size = new System.Drawing.Size(66, 13);
            lblNomClasse.TabIndex = 44;
            lblNomClasse.Text = "Nom Classe:";
            // 
            // txtnomHero
            // 
            this.txtnomHero.Location = new System.Drawing.Point(108, 67);
            this.txtnomHero.Name = "txtnomHero";
            this.txtnomHero.Size = new System.Drawing.Size(264, 20);
            this.txtnomHero.TabIndex = 10;
            // 
            // txtstatBaseDex
            // 
            this.txtstatBaseDex.Location = new System.Drawing.Point(108, 119);
            this.txtstatBaseDex.Name = "txtstatBaseDex";
            this.txtstatBaseDex.Size = new System.Drawing.Size(264, 20);
            this.txtstatBaseDex.TabIndex = 30;
            // 
            // txtstatBaseInt
            // 
            this.txtstatBaseInt.Location = new System.Drawing.Point(108, 145);
            this.txtstatBaseInt.Name = "txtstatBaseInt";
            this.txtstatBaseInt.Size = new System.Drawing.Size(264, 20);
            this.txtstatBaseInt.TabIndex = 32;
            // 
            // txtstatBaseStr
            // 
            this.txtstatBaseStr.Location = new System.Drawing.Point(108, 171);
            this.txtstatBaseStr.Name = "txtstatBaseStr";
            this.txtstatBaseStr.Size = new System.Drawing.Size(264, 20);
            this.txtstatBaseStr.TabIndex = 34;
            // 
            // txtstatBaseVitalite
            // 
            this.txtstatBaseVitalite.Location = new System.Drawing.Point(108, 197);
            this.txtstatBaseVitalite.Name = "txtstatBaseVitalite";
            this.txtstatBaseVitalite.Size = new System.Drawing.Size(264, 20);
            this.txtstatBaseVitalite.TabIndex = 36;
            // 
            // btnCreateHeroFrm
            // 
            this.btnCreateHeroFrm.Font = new System.Drawing.Font("Old English Text MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateHeroFrm.Location = new System.Drawing.Point(15, 281);
            this.btnCreateHeroFrm.Name = "btnCreateHeroFrm";
            this.btnCreateHeroFrm.Size = new System.Drawing.Size(112, 37);
            this.btnCreateHeroFrm.TabIndex = 41;
            this.btnCreateHeroFrm.Text = "Create";
            this.btnCreateHeroFrm.UseVisualStyleBackColor = true;
            this.btnCreateHeroFrm.Click += new System.EventHandler(this.btnCreateHeroFrm_Click);
            // 
            // btnCancelHeroFrm
            // 
            this.btnCancelHeroFrm.Font = new System.Drawing.Font("Old English Text MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelHeroFrm.Location = new System.Drawing.Point(260, 281);
            this.btnCancelHeroFrm.Name = "btnCancelHeroFrm";
            this.btnCancelHeroFrm.Size = new System.Drawing.Size(112, 37);
            this.btnCancelHeroFrm.TabIndex = 42;
            this.btnCancelHeroFrm.Text = "Cancel";
            this.btnCancelHeroFrm.UseVisualStyleBackColor = true;
            this.btnCancelHeroFrm.Click += new System.EventHandler(this.btnCancelHeroFrm_Click);
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Old English Text MT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreate.Location = new System.Drawing.Point(89, 9);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(234, 42);
            this.lblCreate.TabIndex = 43;
            this.lblCreate.Text = "Create a Hero";
            // 
            // cmbDescription
            // 
            this.cmbDescription.FormattingEnabled = true;
            this.cmbDescription.Location = new System.Drawing.Point(108, 223);
            this.cmbDescription.Name = "cmbDescription";
            this.cmbDescription.Size = new System.Drawing.Size(264, 21);
            this.cmbDescription.TabIndex = 44;
            // 
            // cmbNomClass
            // 
            this.cmbNomClass.FormattingEnabled = true;
            this.cmbNomClass.Location = new System.Drawing.Point(108, 92);
            this.cmbNomClass.Name = "cmbNomClass";
            this.cmbNomClass.Size = new System.Drawing.Size(264, 21);
            this.cmbNomClass.TabIndex = 45;
            this.cmbNomClass.SelectedIndexChanged += new System.EventHandler(this.cmbNomClass_SelectedIndexChanged);
            // 
            // heroDetailsDTOBindingSource
            // 
            this.heroDetailsDTOBindingSource.DataSource = typeof(Hugo_LAND.Client.HugoLandServices.HeroDetailsDTO);
            // 
            // frmCreateHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 338);
            this.Controls.Add(lblNomClasse);
            this.Controls.Add(this.cmbNomClass);
            this.Controls.Add(lblMonde);
            this.Controls.Add(this.cmbDescription);
            this.Controls.Add(this.lblCreate);
            this.Controls.Add(this.btnCancelHeroFrm);
            this.Controls.Add(this.btnCreateHeroFrm);
            this.Controls.Add(statBaseDexLabel);
            this.Controls.Add(this.txtstatBaseDex);
            this.Controls.Add(statBaseIntLabel);
            this.Controls.Add(this.txtstatBaseInt);
            this.Controls.Add(statBaseStrLabel);
            this.Controls.Add(this.txtstatBaseStr);
            this.Controls.Add(statBaseVitaliteLabel);
            this.Controls.Add(this.txtstatBaseVitalite);
            this.Controls.Add(nomHeroLabel);
            this.Controls.Add(this.txtnomHero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.TextBox txtstatBaseInt;
        private System.Windows.Forms.TextBox txtstatBaseStr;
        private System.Windows.Forms.TextBox txtstatBaseVitalite;
        private System.Windows.Forms.Button btnCreateHeroFrm;
        private System.Windows.Forms.Button btnCancelHeroFrm;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.ComboBox cmbDescription;
        private System.Windows.Forms.ComboBox cmbNomClass;
    }
}