namespace FolderMonitor.Forms
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            PbLogo = new PictureBox();
            LbNameApp = new Label();
            LbVersion = new Label();
            LbVersion2 = new Label();
            LbCopyright = new Label();
            LbIcons = new Label();
            LbIcons2 = new LinkLabel();
            LbLicense = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)PbLogo).BeginInit();
            SuspendLayout();
            // 
            // PbLogo
            // 
            PbLogo.Image = Properties.Resources.Logo;
            PbLogo.Location = new Point(14, 16);
            PbLogo.Margin = new Padding(3, 4, 3, 4);
            PbLogo.Name = "PbLogo";
            PbLogo.Size = new Size(118, 65);
            PbLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            PbLogo.TabIndex = 0;
            PbLogo.TabStop = false;
            // 
            // LbNameApp
            // 
            LbNameApp.AutoSize = true;
            LbNameApp.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            LbNameApp.Location = new Point(149, 16);
            LbNameApp.Name = "LbNameApp";
            LbNameApp.Size = new Size(187, 32);
            LbNameApp.TabIndex = 1;
            LbNameApp.Text = "Folder Monitor";
            // 
            // LbVersion
            // 
            LbVersion.AutoSize = true;
            LbVersion.Location = new Point(149, 61);
            LbVersion.Name = "LbVersion";
            LbVersion.Size = new Size(60, 20);
            LbVersion.TabIndex = 2;
            LbVersion.Text = "Version:";
            // 
            // LbVersion2
            // 
            LbVersion2.AutoSize = true;
            LbVersion2.Location = new Point(210, 61);
            LbVersion2.Name = "LbVersion2";
            LbVersion2.Size = new Size(50, 20);
            LbVersion2.TabIndex = 3;
            LbVersion2.Text = "label3";
            // 
            // LbCopyright
            // 
            LbCopyright.AutoSize = true;
            LbCopyright.Location = new Point(14, 97);
            LbCopyright.Name = "LbCopyright";
            LbCopyright.Size = new Size(273, 20);
            LbCopyright.TabIndex = 4;
            LbCopyright.Text = "Copyright © 2022 Isaac Morcillo Garcia ";
            // 
            // LbIcons
            // 
            LbIcons.AutoSize = true;
            LbIcons.Location = new Point(14, 121);
            LbIcons.Name = "LbIcons";
            LbIcons.Size = new Size(46, 20);
            LbIcons.TabIndex = 5;
            LbIcons.Text = "Icons:";
            // 
            // LbIcons2
            // 
            LbIcons2.AutoSize = true;
            LbIcons2.Location = new Point(64, 121);
            LbIcons2.Name = "LbIcons2";
            LbIcons2.Size = new Size(83, 20);
            LbIcons2.TabIndex = 6;
            LbIcons2.TabStop = true;
            LbIcons2.Text = "icons8.com";
            LbIcons2.LinkClicked += LbIcons2_LinkClicked;
            // 
            // LbLicense
            // 
            LbLicense.AutoSize = true;
            LbLicense.Location = new Point(14, 147);
            LbLicense.Name = "LbLicense";
            LbLicense.Size = new Size(57, 20);
            LbLicense.TabIndex = 7;
            LbLicense.TabStop = true;
            LbLicense.Text = "License";
            LbLicense.LinkClicked += LbLicense_LinkClicked;
            // 
            // FrmAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 191);
            Controls.Add(LbLicense);
            Controls.Add(LbIcons2);
            Controls.Add(LbIcons);
            Controls.Add(LbCopyright);
            Controls.Add(LbVersion2);
            Controls.Add(LbVersion);
            Controls.Add(LbNameApp);
            Controls.Add(PbLogo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAbout";
            Text = "About Folder Monitor";
            Load += FrmAbout_Load;
            ((System.ComponentModel.ISupportInitialize)PbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PbLogo;
        private Label LbNameApp;
        private Label LbVersion;
        private Label LbVersion2;
        private Label LbCopyright;
        private Label LbIcons;
        private LinkLabel LbIcons2;
        private LinkLabel LbLicense;
    }
}