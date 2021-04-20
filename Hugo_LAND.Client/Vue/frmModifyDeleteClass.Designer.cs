
namespace Hugo_LAND.Client.Vue
{
    partial class frmModifyDeleteClass
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomClasseLabel;
            System.Windows.Forms.Label statBaseDexLabel;
            System.Windows.Forms.Label statBaseIntLabel;
            System.Windows.Forms.Label statBaseStrLabel;
            System.Windows.Forms.Label statBaseVitaliteLabel;
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomClasseTextBox = new System.Windows.Forms.TextBox();
            this.statBaseDexTextBox = new System.Windows.Forms.TextBox();
            this.statBaseIntTextBox = new System.Windows.Forms.TextBox();
            this.statBaseStrTextBox = new System.Windows.Forms.TextBox();
            this.statBaseVitaliteTextBox = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            descriptionLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nomClasseLabel = new System.Windows.Forms.Label();
            statBaseDexLabel = new System.Windows.Forms.Label();
            statBaseIntLabel = new System.Windows.Forms.Label();
            statBaseStrLabel = new System.Windows.Forms.Label();
            statBaseVitaliteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(94, 246);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Description:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(94, 194);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // nomClasseLabel
            // 
            nomClasseLabel.AutoSize = true;
            nomClasseLabel.Location = new System.Drawing.Point(94, 220);
            nomClasseLabel.Name = "nomClasseLabel";
            nomClasseLabel.Size = new System.Drawing.Size(64, 13);
            nomClasseLabel.TabIndex = 5;
            nomClasseLabel.Text = "Class name:";
            // 
            // statBaseDexLabel
            // 
            statBaseDexLabel.AutoSize = true;
            statBaseDexLabel.Location = new System.Drawing.Point(94, 328);
            statBaseDexLabel.Name = "statBaseDexLabel";
            statBaseDexLabel.Size = new System.Drawing.Size(78, 13);
            statBaseDexLabel.TabIndex = 7;
            statBaseDexLabel.Text = "Base Stat Dex:";
            // 
            // statBaseIntLabel
            // 
            statBaseIntLabel.AutoSize = true;
            statBaseIntLabel.Location = new System.Drawing.Point(94, 354);
            statBaseIntLabel.Name = "statBaseIntLabel";
            statBaseIntLabel.Size = new System.Drawing.Size(71, 13);
            statBaseIntLabel.TabIndex = 9;
            statBaseIntLabel.Text = "Base Stat Int:";
            // 
            // statBaseStrLabel
            // 
            statBaseStrLabel.AutoSize = true;
            statBaseStrLabel.Location = new System.Drawing.Point(94, 380);
            statBaseStrLabel.Name = "statBaseStrLabel";
            statBaseStrLabel.Size = new System.Drawing.Size(72, 13);
            statBaseStrLabel.TabIndex = 11;
            statBaseStrLabel.Text = "Base Stat Str:";
            // 
            // statBaseVitaliteLabel
            // 
            statBaseVitaliteLabel.AutoSize = true;
            statBaseVitaliteLabel.Location = new System.Drawing.Point(94, 406);
            statBaseVitaliteLabel.Name = "statBaseVitaliteLabel";
            statBaseVitaliteLabel.Size = new System.Drawing.Size(90, 13);
            statBaseVitaliteLabel.TabIndex = 13;
            statBaseVitaliteLabel.Text = "Base Stat Vitalite:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(190, 243);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(440, 76);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // classeBindingSource
            // 
            this.classeBindingSource.DataSource = typeof(Hugo_LAND.Core.Models.Classe);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(190, 191);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(440, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // nomClasseTextBox
            // 
            this.nomClasseTextBox.Location = new System.Drawing.Point(190, 217);
            this.nomClasseTextBox.Name = "nomClasseTextBox";
            this.nomClasseTextBox.Size = new System.Drawing.Size(440, 20);
            this.nomClasseTextBox.TabIndex = 2;
            // 
            // statBaseDexTextBox
            // 
            this.statBaseDexTextBox.Location = new System.Drawing.Point(190, 325);
            this.statBaseDexTextBox.Name = "statBaseDexTextBox";
            this.statBaseDexTextBox.Size = new System.Drawing.Size(440, 20);
            this.statBaseDexTextBox.TabIndex = 4;
            // 
            // statBaseIntTextBox
            // 
            this.statBaseIntTextBox.Location = new System.Drawing.Point(190, 351);
            this.statBaseIntTextBox.Name = "statBaseIntTextBox";
            this.statBaseIntTextBox.Size = new System.Drawing.Size(440, 20);
            this.statBaseIntTextBox.TabIndex = 5;
            // 
            // statBaseStrTextBox
            // 
            this.statBaseStrTextBox.Location = new System.Drawing.Point(190, 377);
            this.statBaseStrTextBox.Name = "statBaseStrTextBox";
            this.statBaseStrTextBox.Size = new System.Drawing.Size(440, 20);
            this.statBaseStrTextBox.TabIndex = 6;
            // 
            // statBaseVitaliteTextBox
            // 
            this.statBaseVitaliteTextBox.Location = new System.Drawing.Point(190, 403);
            this.statBaseVitaliteTextBox.Name = "statBaseVitaliteTextBox";
            this.statBaseVitaliteTextBox.Size = new System.Drawing.Size(440, 20);
            this.statBaseVitaliteTextBox.TabIndex = 7;
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
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 57);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "🠔";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Old English Text MT", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(75, 103);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(555, 65);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Modify or Delete a class";
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Old English Text MT", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(97, 448);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(209, 128);
            this.btnModify.TabIndex = 8;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModifiy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Old English Text MT", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(421, 448);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(209, 128);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Old English Text MT", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFirst.Location = new System.Drawing.Point(97, 12);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(127, 96);
            this.btnFirst.TabIndex = 26;
            this.btnFirst.Text = "↞";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Old English Text MT", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(503, 12);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(127, 96);
            this.btnLast.TabIndex = 27;
            this.btnLast.Text = "↠";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Old English Text MT", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(370, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(127, 96);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = "→";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Old English Text MT", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrev.Location = new System.Drawing.Point(230, 12);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(127, 96);
            this.btnPrev.TabIndex = 29;
            this.btnPrev.Text = "←";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // frmModifyDeleteClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 608);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
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
            this.Name = "frmModifyDeleteClass";
            this.Text = "frmModifyDeleteClass";
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource classeBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomClasseTextBox;
        private System.Windows.Forms.TextBox statBaseDexTextBox;
        private System.Windows.Forms.TextBox statBaseIntTextBox;
        private System.Windows.Forms.TextBox statBaseStrTextBox;
        private System.Windows.Forms.TextBox statBaseVitaliteTextBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
    }
}