
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
            this.lblHeroManagement = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntCreateHero
            // 
            this.bntCreateHero.BackColor = System.Drawing.Color.Transparent;
            this.bntCreateHero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bntCreateHero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCreateHero.Font = new System.Drawing.Font("Old English Text MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCreateHero.ForeColor = System.Drawing.Color.White;
            this.bntCreateHero.Location = new System.Drawing.Point(28, 131);
            this.bntCreateHero.Name = "bntCreateHero";
            this.bntCreateHero.Size = new System.Drawing.Size(288, 190);
            this.bntCreateHero.TabIndex = 0;
            this.bntCreateHero.Text = "Create Hero";
            this.bntCreateHero.UseVisualStyleBackColor = false;
            this.bntCreateHero.Click += new System.EventHandler(this.bntCreateHero_Click);
            // 
            // btnDeleteHero
            // 
            this.btnDeleteHero.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteHero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteHero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteHero.Font = new System.Drawing.Font("Old English Text MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteHero.ForeColor = System.Drawing.Color.White;
            this.btnDeleteHero.Location = new System.Drawing.Point(470, 131);
            this.btnDeleteHero.Name = "btnDeleteHero";
            this.btnDeleteHero.Size = new System.Drawing.Size(288, 190);
            this.btnDeleteHero.TabIndex = 1;
            this.btnDeleteHero.Text = "Delete Hero";
            this.btnDeleteHero.UseVisualStyleBackColor = false;
            this.btnDeleteHero.Click += new System.EventHandler(this.btnDeleteHero_Click);
            // 
            // lblHeroManagement
            // 
            this.lblHeroManagement.AutoSize = true;
            this.lblHeroManagement.BackColor = System.Drawing.Color.Transparent;
            this.lblHeroManagement.Font = new System.Drawing.Font("Old English Text MT", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroManagement.ForeColor = System.Drawing.Color.White;
            this.lblHeroManagement.Location = new System.Drawing.Point(136, 9);
            this.lblHeroManagement.Name = "lblHeroManagement";
            this.lblHeroManagement.Size = new System.Drawing.Size(454, 79);
            this.lblHeroManagement.TabIndex = 4;
            this.lblHeroManagement.Text = "Hero Manager";
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
            this.btnBack.Location = new System.Drawing.Point(1, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 57);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "🠔";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmManageHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hugo_LAND.Client.Properties.Resources._1920x1080_Might___Magic__Heroes_VI_game_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 377);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHeroManagement);
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
        private System.Windows.Forms.Label lblHeroManagement;
        private System.Windows.Forms.Button btnBack;
    }
}