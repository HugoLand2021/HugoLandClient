namespace Hugo_LAND.Client.Vue
{
    partial class frmHeroSelect
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
            System.Windows.Forms.Label experienceLabel;
            System.Windows.Forms.Label niveauLabel;
            System.Windows.Forms.Label nomHeroLabel;
            System.Windows.Forms.Label statDexLabel;
            System.Windows.Forms.Label statIntLabel;
            System.Windows.Forms.Label statStrLabel;
            System.Windows.Forms.Label statVitaliteLabel;
            System.Windows.Forms.Label nomClasseLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.experienceLabel1 = new System.Windows.Forms.Label();
            this.niveauLabel1 = new System.Windows.Forms.Label();
            this.nomHeroLabel1 = new System.Windows.Forms.Label();
            this.statDexLabel1 = new System.Windows.Forms.Label();
            this.statIntLabel1 = new System.Windows.Forms.Label();
            this.statStrLabel1 = new System.Windows.Forms.Label();
            this.statVitaliteLabel1 = new System.Windows.Forms.Label();
            this.nomClasseLabel1 = new System.Windows.Forms.Label();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.heroDetailsDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            experienceLabel = new System.Windows.Forms.Label();
            niveauLabel = new System.Windows.Forms.Label();
            nomHeroLabel = new System.Windows.Forms.Label();
            statDexLabel = new System.Windows.Forms.Label();
            statIntLabel = new System.Windows.Forms.Label();
            statStrLabel = new System.Windows.Forms.Label();
            statVitaliteLabel = new System.Windows.Forms.Label();
            nomClasseLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heroDetailsDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // experienceLabel
            // 
            experienceLabel.AutoSize = true;
            experienceLabel.Location = new System.Drawing.Point(224, 212);
            experienceLabel.Name = "experienceLabel";
            experienceLabel.Size = new System.Drawing.Size(82, 17);
            experienceLabel.TabIndex = 3;
            experienceLabel.Text = "Experience:";
            // 
            // experienceLabel1
            // 
            this.experienceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Experience", true));
            this.experienceLabel1.Location = new System.Drawing.Point(326, 212);
            this.experienceLabel1.Name = "experienceLabel1";
            this.experienceLabel1.Size = new System.Drawing.Size(104, 23);
            this.experienceLabel1.TabIndex = 4;
            // 
            // niveauLabel
            // 
            niveauLabel.AutoSize = true;
            niveauLabel.Location = new System.Drawing.Point(224, 166);
            niveauLabel.Name = "niveauLabel";
            niveauLabel.Size = new System.Drawing.Size(56, 17);
            niveauLabel.TabIndex = 5;
            niveauLabel.Text = "Niveau:";
            // 
            // niveauLabel1
            // 
            this.niveauLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Niveau", true));
            this.niveauLabel1.Location = new System.Drawing.Point(326, 166);
            this.niveauLabel1.Name = "niveauLabel1";
            this.niveauLabel1.Size = new System.Drawing.Size(104, 23);
            this.niveauLabel1.TabIndex = 6;
            // 
            // nomHeroLabel
            // 
            nomHeroLabel.AutoSize = true;
            nomHeroLabel.Location = new System.Drawing.Point(224, 189);
            nomHeroLabel.Name = "nomHeroLabel";
            nomHeroLabel.Size = new System.Drawing.Size(76, 17);
            nomHeroLabel.TabIndex = 7;
            nomHeroLabel.Text = "Nom Hero:";
            // 
            // nomHeroLabel1
            // 
            this.nomHeroLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "NomHero", true));
            this.nomHeroLabel1.Location = new System.Drawing.Point(326, 189);
            this.nomHeroLabel1.Name = "nomHeroLabel1";
            this.nomHeroLabel1.Size = new System.Drawing.Size(104, 23);
            this.nomHeroLabel1.TabIndex = 8;
            // 
            // statDexLabel
            // 
            statDexLabel.AutoSize = true;
            statDexLabel.Location = new System.Drawing.Point(224, 239);
            statDexLabel.Name = "statDexLabel";
            statDexLabel.Size = new System.Drawing.Size(65, 17);
            statDexLabel.TabIndex = 9;
            statDexLabel.Text = "Stat Dex:";
            // 
            // statDexLabel1
            // 
            this.statDexLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "StatDex", true));
            this.statDexLabel1.Location = new System.Drawing.Point(326, 239);
            this.statDexLabel1.Name = "statDexLabel1";
            this.statDexLabel1.Size = new System.Drawing.Size(104, 23);
            this.statDexLabel1.TabIndex = 10;
            // 
            // statIntLabel
            // 
            statIntLabel.AutoSize = true;
            statIntLabel.Location = new System.Drawing.Point(224, 262);
            statIntLabel.Name = "statIntLabel";
            statIntLabel.Size = new System.Drawing.Size(56, 17);
            statIntLabel.TabIndex = 11;
            statIntLabel.Text = "Stat Int:";
            // 
            // statIntLabel1
            // 
            this.statIntLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "StatInt", true));
            this.statIntLabel1.Location = new System.Drawing.Point(326, 262);
            this.statIntLabel1.Name = "statIntLabel1";
            this.statIntLabel1.Size = new System.Drawing.Size(104, 23);
            this.statIntLabel1.TabIndex = 12;
            // 
            // statStrLabel
            // 
            statStrLabel.AutoSize = true;
            statStrLabel.Location = new System.Drawing.Point(224, 285);
            statStrLabel.Name = "statStrLabel";
            statStrLabel.Size = new System.Drawing.Size(59, 17);
            statStrLabel.TabIndex = 13;
            statStrLabel.Text = "Stat Str:";
            // 
            // statStrLabel1
            // 
            this.statStrLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "StatStr", true));
            this.statStrLabel1.Location = new System.Drawing.Point(326, 285);
            this.statStrLabel1.Name = "statStrLabel1";
            this.statStrLabel1.Size = new System.Drawing.Size(104, 23);
            this.statStrLabel1.TabIndex = 14;
            // 
            // statVitaliteLabel
            // 
            statVitaliteLabel.AutoSize = true;
            statVitaliteLabel.Location = new System.Drawing.Point(224, 308);
            statVitaliteLabel.Name = "statVitaliteLabel";
            statVitaliteLabel.Size = new System.Drawing.Size(83, 17);
            statVitaliteLabel.TabIndex = 15;
            statVitaliteLabel.Text = "Stat Vitalite:";
            // 
            // statVitaliteLabel1
            // 
            this.statVitaliteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "StatVitalite", true));
            this.statVitaliteLabel1.Location = new System.Drawing.Point(326, 308);
            this.statVitaliteLabel1.Name = "statVitaliteLabel1";
            this.statVitaliteLabel1.Size = new System.Drawing.Size(104, 23);
            this.statVitaliteLabel1.TabIndex = 16;
            // 
            // nomClasseLabel
            // 
            nomClasseLabel.AutoSize = true;
            nomClasseLabel.Location = new System.Drawing.Point(224, 149);
            nomClasseLabel.Name = "nomClasseLabel";
            nomClasseLabel.Size = new System.Drawing.Size(87, 17);
            nomClasseLabel.TabIndex = 17;
            nomClasseLabel.Text = "Nom Classe:";
            // 
            // nomClasseLabel1
            // 
            this.nomClasseLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Classe.NomClasse", true));
            this.nomClasseLabel1.Location = new System.Drawing.Point(317, 149);
            this.nomClasseLabel1.Name = "nomClasseLabel1";
            this.nomClasseLabel1.Size = new System.Drawing.Size(100, 23);
            this.nomClasseLabel1.TabIndex = 18;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(224, 108);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 19;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Monde.Description", true));
            this.descriptionLabel1.Location = new System.Drawing.Point(313, 108);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(100, 23);
            this.descriptionLabel1.TabIndex = 20;
            // 
            // heroDetailsDTOBindingSource
            // 
            this.heroDetailsDTOBindingSource.DataSource = typeof(Hugo_LAND.Client.HugoLandServices.HeroDetailsDTO);
            // 
            // frmHeroSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionLabel1);
            this.Controls.Add(nomClasseLabel);
            this.Controls.Add(this.nomClasseLabel1);
            this.Controls.Add(experienceLabel);
            this.Controls.Add(this.experienceLabel1);
            this.Controls.Add(niveauLabel);
            this.Controls.Add(this.niveauLabel1);
            this.Controls.Add(nomHeroLabel);
            this.Controls.Add(this.nomHeroLabel1);
            this.Controls.Add(statDexLabel);
            this.Controls.Add(this.statDexLabel1);
            this.Controls.Add(statIntLabel);
            this.Controls.Add(this.statIntLabel1);
            this.Controls.Add(statStrLabel);
            this.Controls.Add(this.statStrLabel1);
            this.Controls.Add(statVitaliteLabel);
            this.Controls.Add(this.statVitaliteLabel1);
            this.Name = "frmHeroSelect";
            this.Text = "frmHeroSelect";
            ((System.ComponentModel.ISupportInitialize)(this.heroDetailsDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource heroDetailsDTOBindingSource;
        private System.Windows.Forms.Label experienceLabel1;
        private System.Windows.Forms.Label niveauLabel1;
        private System.Windows.Forms.Label nomHeroLabel1;
        private System.Windows.Forms.Label statDexLabel1;
        private System.Windows.Forms.Label statIntLabel1;
        private System.Windows.Forms.Label statStrLabel1;
        private System.Windows.Forms.Label statVitaliteLabel1;
        private System.Windows.Forms.Label nomClasseLabel1;
        private System.Windows.Forms.Label descriptionLabel1;
    }
}