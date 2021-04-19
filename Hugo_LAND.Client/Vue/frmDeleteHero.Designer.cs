
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
            System.Windows.Forms.Label nomHeroLabel;
            this.heroDetailsDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nomHeroComboBox = new System.Windows.Forms.ComboBox();
            nomHeroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heroDetailsDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomHeroLabel
            // 
            nomHeroLabel.AutoSize = true;
            nomHeroLabel.Location = new System.Drawing.Point(13, 64);
            nomHeroLabel.Name = "nomHeroLabel";
            nomHeroLabel.Size = new System.Drawing.Size(58, 13);
            nomHeroLabel.TabIndex = 46;
            nomHeroLabel.Text = "Nom Hero:";
            // 
            // heroDetailsDTOBindingSource
            // 
            this.heroDetailsDTOBindingSource.DataSource = typeof(Hugo_LAND.Client.HugoLandServices.HeroDetailsDTO);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(17, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(123, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nomHeroComboBox
            // 
            this.nomHeroComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroDetailsDTOBindingSource, "NomHero", true));
            this.nomHeroComboBox.FormattingEnabled = true;
            this.nomHeroComboBox.Location = new System.Drawing.Point(77, 61);
            this.nomHeroComboBox.Name = "nomHeroComboBox";
            this.nomHeroComboBox.Size = new System.Drawing.Size(121, 21);
            this.nomHeroComboBox.TabIndex = 47;
            // 
            // frmDeleteHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 189);
            this.Controls.Add(nomHeroLabel);
            this.Controls.Add(this.nomHeroComboBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDeleteHero";
            this.Text = "Delete Hero";
            ((System.ComponentModel.ISupportInitialize)(this.heroDetailsDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource heroDetailsDTOBindingSource;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox nomHeroComboBox;
    }
}