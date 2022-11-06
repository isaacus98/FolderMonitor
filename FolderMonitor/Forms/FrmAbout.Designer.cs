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
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.LbNameApp = new System.Windows.Forms.Label();
            this.LbVersion = new System.Windows.Forms.Label();
            this.LbVersion2 = new System.Windows.Forms.Label();
            this.LbCopyright = new System.Windows.Forms.Label();
            this.LbIcons = new System.Windows.Forms.Label();
            this.LbIcons2 = new System.Windows.Forms.LinkLabel();
            this.LbLicense = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PbLogo
            // 
            this.PbLogo.Image = global::FolderMonitor.Properties.Resources.Logo;
            this.PbLogo.Location = new System.Drawing.Point(12, 12);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(103, 96);
            this.PbLogo.TabIndex = 0;
            this.PbLogo.TabStop = false;
            // 
            // LbNameApp
            // 
            this.LbNameApp.AutoSize = true;
            this.LbNameApp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbNameApp.Location = new System.Drawing.Point(130, 21);
            this.LbNameApp.Name = "LbNameApp";
            this.LbNameApp.Size = new System.Drawing.Size(148, 25);
            this.LbNameApp.TabIndex = 1;
            this.LbNameApp.Text = "Folder Monitor";
            // 
            // LbVersion
            // 
            this.LbVersion.AutoSize = true;
            this.LbVersion.Location = new System.Drawing.Point(130, 46);
            this.LbVersion.Name = "LbVersion";
            this.LbVersion.Size = new System.Drawing.Size(48, 15);
            this.LbVersion.TabIndex = 2;
            this.LbVersion.Text = "Version:";
            // 
            // LbVersion2
            // 
            this.LbVersion2.AutoSize = true;
            this.LbVersion2.Location = new System.Drawing.Point(184, 46);
            this.LbVersion2.Name = "LbVersion2";
            this.LbVersion2.Size = new System.Drawing.Size(38, 15);
            this.LbVersion2.TabIndex = 3;
            this.LbVersion2.Text = "label3";
            // 
            // LbCopyright
            // 
            this.LbCopyright.AutoSize = true;
            this.LbCopyright.Location = new System.Drawing.Point(12, 124);
            this.LbCopyright.Name = "LbCopyright";
            this.LbCopyright.Size = new System.Drawing.Size(216, 15);
            this.LbCopyright.TabIndex = 4;
            this.LbCopyright.Text = "Copyright © 2022 Isaac Morcillo Garcia ";
            // 
            // LbIcons
            // 
            this.LbIcons.AutoSize = true;
            this.LbIcons.Location = new System.Drawing.Point(12, 142);
            this.LbIcons.Name = "LbIcons";
            this.LbIcons.Size = new System.Drawing.Size(38, 15);
            this.LbIcons.TabIndex = 5;
            this.LbIcons.Text = "Icons:";
            // 
            // LbIcons2
            // 
            this.LbIcons2.AutoSize = true;
            this.LbIcons2.Location = new System.Drawing.Point(56, 142);
            this.LbIcons2.Name = "LbIcons2";
            this.LbIcons2.Size = new System.Drawing.Size(68, 15);
            this.LbIcons2.TabIndex = 6;
            this.LbIcons2.TabStop = true;
            this.LbIcons2.Text = "icons8.com";
            this.LbIcons2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbIcons2_LinkClicked);
            // 
            // LbLicense
            // 
            this.LbLicense.AutoSize = true;
            this.LbLicense.Location = new System.Drawing.Point(12, 161);
            this.LbLicense.Name = "LbLicense";
            this.LbLicense.Size = new System.Drawing.Size(46, 15);
            this.LbLicense.TabIndex = 7;
            this.LbLicense.TabStop = true;
            this.LbLicense.Text = "License";
            this.LbLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbLicense_LinkClicked);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 192);
            this.Controls.Add(this.LbLicense);
            this.Controls.Add(this.LbIcons2);
            this.Controls.Add(this.LbIcons);
            this.Controls.Add(this.LbCopyright);
            this.Controls.Add(this.LbVersion2);
            this.Controls.Add(this.LbVersion);
            this.Controls.Add(this.LbNameApp);
            this.Controls.Add(this.PbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.Text = "About Folder Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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