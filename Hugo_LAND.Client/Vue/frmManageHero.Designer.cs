
namespace Hugo_LAND.Client.Vue
{
    partial class frmManageHero
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
            this.bntCreateHero = new System.Windows.Forms.Button();
            this.btnDeleteHero = new System.Windows.Forms.Button();
            this.btnCancelManagement = new System.Windows.Forms.Button();
            this.lblHeroManagement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntCreateHero
            // 
            this.bntCreateHero.BackColor = System.Drawing.Color.Gray;
            this.bntCreateHero.Font = new System.Drawing.Font("Old English Text MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCreateHero.Location = new System.Drawing.Point(108, 113);
            this.bntCreateHero.Name = "bntCreateHero";
            this.bntCreateHero.Size = new System.Drawing.Size(215, 131);
            this.bntCreateHero.TabIndex = 0;
            this.bntCreateHero.Text = "Create Hero";
            this.bntCreateHero.UseVisualStyleBackColor = false;
            this.bntCreateHero.Click += new System.EventHandler(this.bntCreateHero_Click);
            // 
            // btnDeleteHero
            // 
            this.btnDeleteHero.BackColor = System.Drawing.Color.DarkGray;
            this.btnDeleteHero.Font = new System.Drawing.Font("Old English Text MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteHero.Location = new System.Drawing.Point(449, 113);
            this.btnDeleteHero.Name = "btnDeleteHero";
            this.btnDeleteHero.Size = new System.Drawing.Size(215, 131);
            this.btnDeleteHero.TabIndex = 1;
            this.btnDeleteHero.Text = "Delete Hero";
            this.btnDeleteHero.UseVisualStyleBackColor = false;
            this.btnDeleteHero.Click += new System.EventHandler(this.btnDeleteHero_Click);
            // 
            // btnCancelManagement
            // 
            this.btnCancelManagement.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelManagement.Font = new System.Drawing.Font("Old English Text MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelManagement.Location = new System.Drawing.Point(277, 277);
            this.btnCancelManagement.Name = "btnCancelManagement";
            this.btnCancelManagement.Size = new System.Drawing.Size(215, 131);
            this.btnCancelManagement.TabIndex = 3;
            this.btnCancelManagement.Text = "Cancel";
            this.btnCancelManagement.UseVisualStyleBackColor = false;
            this.btnCancelManagement.Click += new System.EventHandler(this.btnCancelManagement_Click);
            // 
            // lblHeroManagement
            // 
            this.lblHeroManagement.AutoSize = true;
            this.lblHeroManagement.BackColor = System.Drawing.Color.Transparent;
            this.lblHeroManagement.Font = new System.Drawing.Font("Old English Text MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroManagement.Location = new System.Drawing.Point(184, 9);
            this.lblHeroManagement.Name = "lblHeroManagement";
            this.lblHeroManagement.Size = new System.Drawing.Size(409, 57);
            this.lblHeroManagement.TabIndex = 4;
            this.lblHeroManagement.Text = "Hero Management";
            // 
            // frmManageHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hugo_LAND.Client.Properties.Resources._1920x1080_Might___Magic__Heroes_VI_game_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.lblHeroManagement);
            this.Controls.Add(this.btnCancelManagement);
            this.Controls.Add(this.btnDeleteHero);
            this.Controls.Add(this.bntCreateHero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageHero";
            this.Text = "Manage Hero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCreateHero;
        private System.Windows.Forms.Button btnDeleteHero;
        private System.Windows.Forms.Button btnCancelManagement;
        private System.Windows.Forms.Label lblHeroManagement;
    }
}