
namespace Hugo_LAND.Client.Vue
{
    partial class frmClassManager
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnModifyDeleteClass = new System.Windows.Forms.Button();
            this.btnCreateClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "🠔";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Old English Text MT", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(97, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(411, 71);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Class Manager";
            // 
            // btnModifyDeleteClass
            // 
            this.btnModifyDeleteClass.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyDeleteClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnModifyDeleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyDeleteClass.Font = new System.Drawing.Font("Old English Text MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyDeleteClass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifyDeleteClass.Location = new System.Drawing.Point(333, 220);
            this.btnModifyDeleteClass.Name = "btnModifyDeleteClass";
            this.btnModifyDeleteClass.Size = new System.Drawing.Size(204, 182);
            this.btnModifyDeleteClass.TabIndex = 20;
            this.btnModifyDeleteClass.Text = "Modify or Delete a class...";
            this.btnModifyDeleteClass.UseVisualStyleBackColor = false;
            this.btnModifyDeleteClass.Click += new System.EventHandler(this.btnModifyDeleteClass_Click);
            // 
            // btnCreateClass
            // 
            this.btnCreateClass.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCreateClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateClass.Font = new System.Drawing.Font("Old English Text MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateClass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateClass.Location = new System.Drawing.Point(12, 220);
            this.btnCreateClass.Name = "btnCreateClass";
            this.btnCreateClass.Size = new System.Drawing.Size(204, 182);
            this.btnCreateClass.TabIndex = 21;
            this.btnCreateClass.Text = "Create a class...";
            this.btnCreateClass.UseVisualStyleBackColor = false;
            this.btnCreateClass.Click += new System.EventHandler(this.btnCreateClass_Click);
            // 
            // frmClassManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hugo_LAND.Client.Properties.Resources.raoni_barcelos_desenho_octavio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 414);
            this.Controls.Add(this.btnCreateClass);
            this.Controls.Add(this.btnModifyDeleteClass);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmClassManager";
            this.Text = "frmClassManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnModifyDeleteClass;
        private System.Windows.Forms.Button btnCreateClass;
    }
}