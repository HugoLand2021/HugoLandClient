
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
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label nomClasseLabel;
            System.Windows.Forms.Label statBaseDexLabel;
            System.Windows.Forms.Label statBaseIntLabel;
            System.Windows.Forms.Label statBaseStrLabel;
            System.Windows.Forms.Label statBaseVitaliteLabel;
            System.Windows.Forms.Label idLabel2;
            this.heroDetailsDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomHeroTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.nomClasseTextBox = new System.Windows.Forms.TextBox();
            this.statBaseDexTextBox = new System.Windows.Forms.TextBox();
            this.statBaseIntTextBox = new System.Windows.Forms.TextBox();
            this.statBaseStrTextBox = new System.Windows.Forms.TextBox();
            this.statBaseVitaliteTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox2 = new System.Windows.Forms.TextBox();
            this.btnCreateHeroFrm = new System.Windows.Forms.Button();
            this.btnCancelHeroFrm = new System.Windows.Forms.Button();
            nomHeroLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            nomClasseLabel = new System.Windows.Forms.Label();
            statBaseDexLabel = new System.Windows.Forms.Label();
            statBaseIntLabel = new System.Windows.Forms.Label();
            statBaseStrLabel = new System.Windows.Forms.Label();
            statBaseVitaliteLabel = new System.Windows.Forms.Label();
            idLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heroDetailsDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // heroDetailsDTOBindingSource
            // 
            this.heroDetailsDTOBindingSource.DataSource = typeof(Hugo_LAND.Client.HugoLandServices.HeroDetailsDTO);
            // 
            // nomHeroLabel
            // 
            nomHeroLabel.AutoSize = true;
            nomHeroLabel.Location = new System.Drawing.Point(12, 18);
            nomHeroLabel.Name = "nomHeroLabel";
            nomHeroLabel.Size = new System.Drawing.Size(58, 13);
            nomHeroLabel.TabIndex = 9;
            nomHeroLabel.Text = "Nom Hero:";
            // 
            // nomHeroTextBox
            // 
            this.nomHeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "NomHero", true));
            this.nomHeroTextBox.Location = new System.Drawing.Point(108, 15);
            this.nomHeroTextBox.Name = "nomHeroTextBox";
            this.nomHeroTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomHeroTextBox.TabIndex = 10;
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(12, 44);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(53, 13);
            idLabel1.TabIndex = 25;
            idLabel1.Text = "Id Classe:";
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Classe.Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(108, 41);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(100, 20);
            this.idTextBox1.TabIndex = 26;
            // 
            // nomClasseLabel
            // 
            nomClasseLabel.AutoSize = true;
            nomClasseLabel.Location = new System.Drawing.Point(12, 70);
            nomClasseLabel.Name = "nomClasseLabel";
            nomClasseLabel.Size = new System.Drawing.Size(66, 13);
            nomClasseLabel.TabIndex = 27;
            nomClasseLabel.Text = "Nom Classe:";
            // 
            // nomClasseTextBox
            // 
            this.nomClasseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Classe.NomClasse", true));
            this.nomClasseTextBox.Location = new System.Drawing.Point(108, 67);
            this.nomClasseTextBox.Name = "nomClasseTextBox";
            this.nomClasseTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomClasseTextBox.TabIndex = 28;
            // 
            // statBaseDexLabel
            // 
            statBaseDexLabel.AutoSize = true;
            statBaseDexLabel.Location = new System.Drawing.Point(12, 96);
            statBaseDexLabel.Name = "statBaseDexLabel";
            statBaseDexLabel.Size = new System.Drawing.Size(78, 13);
            statBaseDexLabel.TabIndex = 29;
            statBaseDexLabel.Text = "Stat Base Dex:";
            // 
            // statBaseDexTextBox
            // 
            this.statBaseDexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Classe.StatBaseDex", true));
            this.statBaseDexTextBox.Location = new System.Drawing.Point(108, 93);
            this.statBaseDexTextBox.Name = "statBaseDexTextBox";
            this.statBaseDexTextBox.Size = new System.Drawing.Size(100, 20);
            this.statBaseDexTextBox.TabIndex = 30;
            // 
            // statBaseIntLabel
            // 
            statBaseIntLabel.AutoSize = true;
            statBaseIntLabel.Location = new System.Drawing.Point(12, 122);
            statBaseIntLabel.Name = "statBaseIntLabel";
            statBaseIntLabel.Size = new System.Drawing.Size(71, 13);
            statBaseIntLabel.TabIndex = 31;
            statBaseIntLabel.Text = "Stat Base Int:";
            // 
            // statBaseIntTextBox
            // 
            this.statBaseIntTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Classe.StatBaseInt", true));
            this.statBaseIntTextBox.Location = new System.Drawing.Point(108, 119);
            this.statBaseIntTextBox.Name = "statBaseIntTextBox";
            this.statBaseIntTextBox.Size = new System.Drawing.Size(100, 20);
            this.statBaseIntTextBox.TabIndex = 32;
            // 
            // statBaseStrLabel
            // 
            statBaseStrLabel.AutoSize = true;
            statBaseStrLabel.Location = new System.Drawing.Point(12, 148);
            statBaseStrLabel.Name = "statBaseStrLabel";
            statBaseStrLabel.Size = new System.Drawing.Size(72, 13);
            statBaseStrLabel.TabIndex = 33;
            statBaseStrLabel.Text = "Stat Base Str:";
            // 
            // statBaseStrTextBox
            // 
            this.statBaseStrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Classe.StatBaseStr", true));
            this.statBaseStrTextBox.Location = new System.Drawing.Point(108, 145);
            this.statBaseStrTextBox.Name = "statBaseStrTextBox";
            this.statBaseStrTextBox.Size = new System.Drawing.Size(100, 20);
            this.statBaseStrTextBox.TabIndex = 34;
            // 
            // statBaseVitaliteLabel
            // 
            statBaseVitaliteLabel.AutoSize = true;
            statBaseVitaliteLabel.Location = new System.Drawing.Point(12, 174);
            statBaseVitaliteLabel.Name = "statBaseVitaliteLabel";
            statBaseVitaliteLabel.Size = new System.Drawing.Size(90, 13);
            statBaseVitaliteLabel.TabIndex = 35;
            statBaseVitaliteLabel.Text = "Stat Base Vitalite:";
            // 
            // statBaseVitaliteTextBox
            // 
            this.statBaseVitaliteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Classe.StatBaseVitalite", true));
            this.statBaseVitaliteTextBox.Location = new System.Drawing.Point(108, 171);
            this.statBaseVitaliteTextBox.Name = "statBaseVitaliteTextBox";
            this.statBaseVitaliteTextBox.Size = new System.Drawing.Size(100, 20);
            this.statBaseVitaliteTextBox.TabIndex = 36;
            // 
            // idTextBox2
            // 
            this.idTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Monde.Id", true));
            this.idTextBox2.Location = new System.Drawing.Point(108, 197);
            this.idTextBox2.Name = "idTextBox2";
            this.idTextBox2.Size = new System.Drawing.Size(100, 20);
            this.idTextBox2.TabIndex = 40;
            // 
            // idLabel2
            // 
            idLabel2.AutoSize = true;
            idLabel2.Location = new System.Drawing.Point(12, 200);
            idLabel2.Name = "idLabel2";
            idLabel2.Size = new System.Drawing.Size(55, 13);
            idLabel2.TabIndex = 39;
            idLabel2.Text = "Id Monde:";
            // 
            // btnCreateHeroFrm
            // 
            this.btnCreateHeroFrm.Location = new System.Drawing.Point(15, 229);
            this.btnCreateHeroFrm.Name = "btnCreateHeroFrm";
            this.btnCreateHeroFrm.Size = new System.Drawing.Size(75, 23);
            this.btnCreateHeroFrm.TabIndex = 41;
            this.btnCreateHeroFrm.Text = "Create";
            this.btnCreateHeroFrm.UseVisualStyleBackColor = true;
            // 
            // btnCancelHeroFrm
            // 
            this.btnCancelHeroFrm.Location = new System.Drawing.Point(133, 229);
            this.btnCancelHeroFrm.Name = "btnCancelHeroFrm";
            this.btnCancelHeroFrm.Size = new System.Drawing.Size(75, 23);
            this.btnCancelHeroFrm.TabIndex = 42;
            this.btnCancelHeroFrm.Text = "Cancel";
            this.btnCancelHeroFrm.UseVisualStyleBackColor = true;
            // 
            // frmCreateHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 265);
            this.Controls.Add(this.btnCancelHeroFrm);
            this.Controls.Add(this.btnCreateHeroFrm);
            this.Controls.Add(idLabel2);
            this.Controls.Add(this.idTextBox2);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(nomClasseLabel);
            this.Controls.Add(this.nomClasseTextBox);
            this.Controls.Add(statBaseDexLabel);
            this.Controls.Add(this.statBaseDexTextBox);
            this.Controls.Add(statBaseIntLabel);
            this.Controls.Add(this.statBaseIntTextBox);
            this.Controls.Add(statBaseStrLabel);
            this.Controls.Add(this.statBaseStrTextBox);
            this.Controls.Add(statBaseVitaliteLabel);
            this.Controls.Add(this.statBaseVitaliteTextBox);
            this.Controls.Add(nomHeroLabel);
            this.Controls.Add(this.nomHeroTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCreateHero";
            this.Text = "Create Hero";
            ((System.ComponentModel.ISupportInitialize)(this.heroDetailsDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource heroDetailsDTOBindingSource;
        private System.Windows.Forms.TextBox nomHeroTextBox;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox nomClasseTextBox;
        private System.Windows.Forms.TextBox statBaseDexTextBox;
        private System.Windows.Forms.TextBox statBaseIntTextBox;
        private System.Windows.Forms.TextBox statBaseStrTextBox;
        private System.Windows.Forms.TextBox statBaseVitaliteTextBox;
        private System.Windows.Forms.TextBox idTextBox2;
        private System.Windows.Forms.Button btnCreateHeroFrm;
        private System.Windows.Forms.Button btnCancelHeroFrm;
    }
}