
namespace Hugo_LAND.Client.Vue
{
    partial class frmMain
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHero = new System.Windows.Forms.Button();
            this.btnClassManagement = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStart.Font = new System.Drawing.Font("Old English Text MT", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(96, 249);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(199, 101);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Game Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHero
            // 
            this.btnHero.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHero.Font = new System.Drawing.Font("Old English Text MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHero.Location = new System.Drawing.Point(653, 249);
            this.btnHero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHero.Name = "btnHero";
            this.btnHero.Size = new System.Drawing.Size(199, 101);
            this.btnHero.TabIndex = 1;
            this.btnHero.Text = "Hero Management";
            this.btnHero.UseVisualStyleBackColor = false;
            this.btnHero.Click += new System.EventHandler(this.btnHero_Click);
            // 
            // btnClassManagement
            // 
            this.btnClassManagement.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClassManagement.Enabled = false;
            this.btnClassManagement.Font = new System.Drawing.Font("Old English Text MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassManagement.Location = new System.Drawing.Point(375, 249);
            this.btnClassManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClassManagement.Name = "btnClassManagement";
            this.btnClassManagement.Size = new System.Drawing.Size(199, 101);
            this.btnClassManagement.TabIndex = 2;
            this.btnClassManagement.Text = "Class Management";
            this.btnClassManagement.UseVisualStyleBackColor = false;
            this.btnClassManagement.Visible = false;
            this.btnClassManagement.Click += new System.EventHandler(this.btnClassManagement_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsername.Font = new System.Drawing.Font("Old English Text MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Red;
            this.lblUsername.Location = new System.Drawing.Point(83, 98);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 71);
            this.lblUsername.TabIndex = 3;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWelcome.Font = new System.Drawing.Font("Old English Text MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Red;
            this.lblWelcome.Location = new System.Drawing.Point(83, 11);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(752, 71);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome to Crusader Knight";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Old English Text MT", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(815, 466);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hugo_LAND.Client.Properties.Resources.chevalier;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnClassManagement);
            this.Controls.Add(this.btnHero);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Main menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHero;
        private System.Windows.Forms.Button btnClassManagement;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button button1;
    }
}