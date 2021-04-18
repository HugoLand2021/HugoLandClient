
namespace Hugo_LAND.Client.Vue
{
    partial class frmDeleteHero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteHero));
            System.Windows.Forms.Label experienceLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label niveauLabel;
            System.Windows.Forms.Label nomHeroLabel;
            System.Windows.Forms.Label statDexLabel;
            System.Windows.Forms.Label statIntLabel;
            System.Windows.Forms.Label statStrLabel;
            System.Windows.Forms.Label statVitaliteLabel;
            System.Windows.Forms.Label xLabel;
            System.Windows.Forms.Label yLabel;
            System.Windows.Forms.Label nomClasseLabel;
            System.Windows.Forms.Label descriptionLabel1;
            System.Windows.Forms.Label idLabel2;
            System.Windows.Forms.Label limiteXLabel;
            System.Windows.Forms.Label limiteYLabel;
            this.heroDetailsDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heroDetailsDTOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.experienceTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.niveauTextBox = new System.Windows.Forms.TextBox();
            this.nomHeroTextBox = new System.Windows.Forms.TextBox();
            this.statDexTextBox = new System.Windows.Forms.TextBox();
            this.statIntTextBox = new System.Windows.Forms.TextBox();
            this.statStrTextBox = new System.Windows.Forms.TextBox();
            this.statVitaliteTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.nomClasseTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox1 = new System.Windows.Forms.TextBox();
            this.idTextBox2 = new System.Windows.Forms.TextBox();
            this.limiteXTextBox = new System.Windows.Forms.TextBox();
            this.limiteYTextBox = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            experienceLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            niveauLabel = new System.Windows.Forms.Label();
            nomHeroLabel = new System.Windows.Forms.Label();
            statDexLabel = new System.Windows.Forms.Label();
            statIntLabel = new System.Windows.Forms.Label();
            statStrLabel = new System.Windows.Forms.Label();
            statVitaliteLabel = new System.Windows.Forms.Label();
            xLabel = new System.Windows.Forms.Label();
            yLabel = new System.Windows.Forms.Label();
            nomClasseLabel = new System.Windows.Forms.Label();
            descriptionLabel1 = new System.Windows.Forms.Label();
            idLabel2 = new System.Windows.Forms.Label();
            limiteXLabel = new System.Windows.Forms.Label();
            limiteYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heroDetailsDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroDetailsDTOBindingNavigator)).BeginInit();
            this.heroDetailsDTOBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // heroDetailsDTOBindingSource
            // 
            this.heroDetailsDTOBindingSource.DataSource = typeof(Hugo_LAND.Client.HugoLandServices.HeroDetailsDTO);
            // 
            // heroDetailsDTOBindingNavigator
            // 
            this.heroDetailsDTOBindingNavigator.AddNewItem = null;
            this.heroDetailsDTOBindingNavigator.BindingSource = this.heroDetailsDTOBindingSource;
            this.heroDetailsDTOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.heroDetailsDTOBindingNavigator.DeleteItem = null;
            this.heroDetailsDTOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.heroDetailsDTOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.heroDetailsDTOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.heroDetailsDTOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.heroDetailsDTOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.heroDetailsDTOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.heroDetailsDTOBindingNavigator.Name = "heroDetailsDTOBindingNavigator";
            this.heroDetailsDTOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.heroDetailsDTOBindingNavigator.Size = new System.Drawing.Size(219, 25);
            this.heroDetailsDTOBindingNavigator.TabIndex = 0;
            this.heroDetailsDTOBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // experienceLabel
            // 
            experienceLabel.AutoSize = true;
            experienceLabel.Location = new System.Drawing.Point(12, 46);
            experienceLabel.Name = "experienceLabel";
            experienceLabel.Size = new System.Drawing.Size(63, 13);
            experienceLabel.TabIndex = 3;
            experienceLabel.Text = "Experience:";
            // 
            // experienceTextBox
            // 
            this.experienceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Experience", true));
            this.experienceTextBox.Location = new System.Drawing.Point(92, 43);
            this.experienceTextBox.Name = "experienceTextBox";
            this.experienceTextBox.Size = new System.Drawing.Size(104, 20);
            this.experienceTextBox.TabIndex = 4;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 72);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(92, 69);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(104, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // niveauLabel
            // 
            niveauLabel.AutoSize = true;
            niveauLabel.Location = new System.Drawing.Point(12, 98);
            niveauLabel.Name = "niveauLabel";
            niveauLabel.Size = new System.Drawing.Size(44, 13);
            niveauLabel.TabIndex = 7;
            niveauLabel.Text = "Niveau:";
            // 
            // niveauTextBox
            // 
            this.niveauTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Niveau", true));
            this.niveauTextBox.Location = new System.Drawing.Point(92, 95);
            this.niveauTextBox.Name = "niveauTextBox";
            this.niveauTextBox.Size = new System.Drawing.Size(104, 20);
            this.niveauTextBox.TabIndex = 8;
            // 
            // nomHeroLabel
            // 
            nomHeroLabel.AutoSize = true;
            nomHeroLabel.Location = new System.Drawing.Point(12, 124);
            nomHeroLabel.Name = "nomHeroLabel";
            nomHeroLabel.Size = new System.Drawing.Size(58, 13);
            nomHeroLabel.TabIndex = 9;
            nomHeroLabel.Text = "Nom Hero:";
            // 
            // nomHeroTextBox
            // 
            this.nomHeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "NomHero", true));
            this.nomHeroTextBox.Location = new System.Drawing.Point(92, 121);
            this.nomHeroTextBox.Name = "nomHeroTextBox";
            this.nomHeroTextBox.Size = new System.Drawing.Size(104, 20);
            this.nomHeroTextBox.TabIndex = 10;
            // 
            // statDexLabel
            // 
            statDexLabel.AutoSize = true;
            statDexLabel.Location = new System.Drawing.Point(12, 150);
            statDexLabel.Name = "statDexLabel";
            statDexLabel.Size = new System.Drawing.Size(51, 13);
            statDexLabel.TabIndex = 11;
            statDexLabel.Text = "Stat Dex:";
            // 
            // statDexTextBox
            // 
            this.statDexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "StatDex", true));
            this.statDexTextBox.Location = new System.Drawing.Point(92, 147);
            this.statDexTextBox.Name = "statDexTextBox";
            this.statDexTextBox.Size = new System.Drawing.Size(104, 20);
            this.statDexTextBox.TabIndex = 12;
            // 
            // statIntLabel
            // 
            statIntLabel.AutoSize = true;
            statIntLabel.Location = new System.Drawing.Point(12, 176);
            statIntLabel.Name = "statIntLabel";
            statIntLabel.Size = new System.Drawing.Size(44, 13);
            statIntLabel.TabIndex = 13;
            statIntLabel.Text = "Stat Int:";
            // 
            // statIntTextBox
            // 
            this.statIntTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "StatInt", true));
            this.statIntTextBox.Location = new System.Drawing.Point(92, 173);
            this.statIntTextBox.Name = "statIntTextBox";
            this.statIntTextBox.Size = new System.Drawing.Size(104, 20);
            this.statIntTextBox.TabIndex = 14;
            // 
            // statStrLabel
            // 
            statStrLabel.AutoSize = true;
            statStrLabel.Location = new System.Drawing.Point(12, 202);
            statStrLabel.Name = "statStrLabel";
            statStrLabel.Size = new System.Drawing.Size(45, 13);
            statStrLabel.TabIndex = 15;
            statStrLabel.Text = "Stat Str:";
            // 
            // statStrTextBox
            // 
            this.statStrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "StatStr", true));
            this.statStrTextBox.Location = new System.Drawing.Point(92, 199);
            this.statStrTextBox.Name = "statStrTextBox";
            this.statStrTextBox.Size = new System.Drawing.Size(104, 20);
            this.statStrTextBox.TabIndex = 16;
            // 
            // statVitaliteLabel
            // 
            statVitaliteLabel.AutoSize = true;
            statVitaliteLabel.Location = new System.Drawing.Point(12, 228);
            statVitaliteLabel.Name = "statVitaliteLabel";
            statVitaliteLabel.Size = new System.Drawing.Size(63, 13);
            statVitaliteLabel.TabIndex = 17;
            statVitaliteLabel.Text = "Stat Vitalite:";
            // 
            // statVitaliteTextBox
            // 
            this.statVitaliteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "StatVitalite", true));
            this.statVitaliteTextBox.Location = new System.Drawing.Point(92, 225);
            this.statVitaliteTextBox.Name = "statVitaliteTextBox";
            this.statVitaliteTextBox.Size = new System.Drawing.Size(104, 20);
            this.statVitaliteTextBox.TabIndex = 18;
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new System.Drawing.Point(12, 254);
            xLabel.Name = "xLabel";
            xLabel.Size = new System.Drawing.Size(15, 13);
            xLabel.TabIndex = 19;
            xLabel.Text = "x:";
            // 
            // xTextBox
            // 
            this.xTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "x", true));
            this.xTextBox.Location = new System.Drawing.Point(92, 251);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(104, 20);
            this.xTextBox.TabIndex = 20;
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Location = new System.Drawing.Point(12, 280);
            yLabel.Name = "yLabel";
            yLabel.Size = new System.Drawing.Size(15, 13);
            yLabel.TabIndex = 21;
            yLabel.Text = "y:";
            // 
            // yTextBox
            // 
            this.yTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "y", true));
            this.yTextBox.Location = new System.Drawing.Point(92, 277);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(104, 20);
            this.yTextBox.TabIndex = 22;
            // 
            // nomClasseLabel
            // 
            nomClasseLabel.AutoSize = true;
            nomClasseLabel.Location = new System.Drawing.Point(12, 305);
            nomClasseLabel.Name = "nomClasseLabel";
            nomClasseLabel.Size = new System.Drawing.Size(66, 13);
            nomClasseLabel.TabIndex = 27;
            nomClasseLabel.Text = "Nom Classe:";
            // 
            // nomClasseTextBox
            // 
            this.nomClasseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Classe.NomClasse", true));
            this.nomClasseTextBox.Location = new System.Drawing.Point(92, 302);
            this.nomClasseTextBox.Name = "nomClasseTextBox";
            this.nomClasseTextBox.Size = new System.Drawing.Size(104, 20);
            this.nomClasseTextBox.TabIndex = 28;
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Location = new System.Drawing.Point(12, 331);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(63, 13);
            descriptionLabel1.TabIndex = 37;
            descriptionLabel1.Text = "Description:";
            // 
            // descriptionTextBox1
            // 
            this.descriptionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Monde.Description", true));
            this.descriptionTextBox1.Location = new System.Drawing.Point(92, 328);
            this.descriptionTextBox1.Name = "descriptionTextBox1";
            this.descriptionTextBox1.Size = new System.Drawing.Size(104, 20);
            this.descriptionTextBox1.TabIndex = 38;
            // 
            // idLabel2
            // 
            idLabel2.AutoSize = true;
            idLabel2.Location = new System.Drawing.Point(12, 357);
            idLabel2.Name = "idLabel2";
            idLabel2.Size = new System.Drawing.Size(19, 13);
            idLabel2.TabIndex = 39;
            idLabel2.Text = "Id:";
            // 
            // idTextBox2
            // 
            this.idTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Monde.Id", true));
            this.idTextBox2.Location = new System.Drawing.Point(92, 354);
            this.idTextBox2.Name = "idTextBox2";
            this.idTextBox2.Size = new System.Drawing.Size(104, 20);
            this.idTextBox2.TabIndex = 40;
            // 
            // limiteXLabel
            // 
            limiteXLabel.AutoSize = true;
            limiteXLabel.Location = new System.Drawing.Point(12, 383);
            limiteXLabel.Name = "limiteXLabel";
            limiteXLabel.Size = new System.Drawing.Size(47, 13);
            limiteXLabel.TabIndex = 41;
            limiteXLabel.Text = "Limite X:";
            // 
            // limiteXTextBox
            // 
            this.limiteXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Monde.LimiteX", true));
            this.limiteXTextBox.Location = new System.Drawing.Point(92, 380);
            this.limiteXTextBox.Name = "limiteXTextBox";
            this.limiteXTextBox.Size = new System.Drawing.Size(104, 20);
            this.limiteXTextBox.TabIndex = 42;
            // 
            // limiteYLabel
            // 
            limiteYLabel.AutoSize = true;
            limiteYLabel.Location = new System.Drawing.Point(12, 409);
            limiteYLabel.Name = "limiteYLabel";
            limiteYLabel.Size = new System.Drawing.Size(47, 13);
            limiteYLabel.TabIndex = 43;
            limiteYLabel.Text = "Limite Y:";
            // 
            // limiteYTextBox
            // 
            this.limiteYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "Monde.LimiteY", true));
            this.limiteYTextBox.Location = new System.Drawing.Point(92, 406);
            this.limiteYTextBox.Name = "limiteYTextBox";
            this.limiteYTextBox.Size = new System.Drawing.Size(104, 20);
            this.limiteYTextBox.TabIndex = 44;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(121, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmDeleteHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 505);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(descriptionLabel1);
            this.Controls.Add(this.descriptionTextBox1);
            this.Controls.Add(idLabel2);
            this.Controls.Add(this.idTextBox2);
            this.Controls.Add(limiteXLabel);
            this.Controls.Add(this.limiteXTextBox);
            this.Controls.Add(limiteYLabel);
            this.Controls.Add(this.limiteYTextBox);
            this.Controls.Add(nomClasseLabel);
            this.Controls.Add(this.nomClasseTextBox);
            this.Controls.Add(experienceLabel);
            this.Controls.Add(this.experienceTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(niveauLabel);
            this.Controls.Add(this.niveauTextBox);
            this.Controls.Add(nomHeroLabel);
            this.Controls.Add(this.nomHeroTextBox);
            this.Controls.Add(statDexLabel);
            this.Controls.Add(this.statDexTextBox);
            this.Controls.Add(statIntLabel);
            this.Controls.Add(this.statIntTextBox);
            this.Controls.Add(statStrLabel);
            this.Controls.Add(this.statStrTextBox);
            this.Controls.Add(statVitaliteLabel);
            this.Controls.Add(this.statVitaliteTextBox);
            this.Controls.Add(xLabel);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(yLabel);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.heroDetailsDTOBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDeleteHero";
            this.Text = "Delete Hero";
            ((System.ComponentModel.ISupportInitialize)(this.heroDetailsDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroDetailsDTOBindingNavigator)).EndInit();
            this.heroDetailsDTOBindingNavigator.ResumeLayout(false);
            this.heroDetailsDTOBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource heroDetailsDTOBindingSource;
        private System.Windows.Forms.BindingNavigator heroDetailsDTOBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox experienceTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox niveauTextBox;
        private System.Windows.Forms.TextBox nomHeroTextBox;
        private System.Windows.Forms.TextBox statDexTextBox;
        private System.Windows.Forms.TextBox statIntTextBox;
        private System.Windows.Forms.TextBox statStrTextBox;
        private System.Windows.Forms.TextBox statVitaliteTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox nomClasseTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox1;
        private System.Windows.Forms.TextBox idTextBox2;
        private System.Windows.Forms.TextBox limiteXTextBox;
        private System.Windows.Forms.TextBox limiteYTextBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
    }
}