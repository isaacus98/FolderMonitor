namespace FolderMonitor.Forms
{
    partial class FrmAddFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddFolder));
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.BtSearch = new System.Windows.Forms.Button();
            this.GbxOptions = new System.Windows.Forms.GroupBox();
            this.ChkIncludeSubdirectories = new System.Windows.Forms.CheckBox();
            this.GbxEvents = new System.Windows.Forms.GroupBox();
            this.ChkDeleted = new System.Windows.Forms.CheckBox();
            this.ChkRenamed = new System.Windows.Forms.CheckBox();
            this.ChkChanged = new System.Windows.Forms.CheckBox();
            this.ChkCreated = new System.Windows.Forms.CheckBox();
            this.BtSave = new System.Windows.Forms.Button();
            this.BtCancel = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.GbxOptions.SuspendLayout();
            this.GbxEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(12, 12);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(260, 23);
            this.TxtPath.TabIndex = 0;
            // 
            // BtSearch
            // 
            this.BtSearch.Location = new System.Drawing.Point(278, 11);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.Size = new System.Drawing.Size(24, 24);
            this.BtSearch.TabIndex = 1;
            this.BtSearch.Text = "...";
            this.BtSearch.UseVisualStyleBackColor = true;
            // 
            // GbxOptions
            // 
            this.GbxOptions.Controls.Add(this.ChkIncludeSubdirectories);
            this.GbxOptions.Location = new System.Drawing.Point(12, 41);
            this.GbxOptions.Name = "GbxOptions";
            this.GbxOptions.Size = new System.Drawing.Size(290, 54);
            this.GbxOptions.TabIndex = 2;
            this.GbxOptions.TabStop = false;
            this.GbxOptions.Text = "Options";
            // 
            // ChkIncludeSubdirectories
            // 
            this.ChkIncludeSubdirectories.AutoSize = true;
            this.ChkIncludeSubdirectories.Checked = true;
            this.ChkIncludeSubdirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkIncludeSubdirectories.Location = new System.Drawing.Point(6, 22);
            this.ChkIncludeSubdirectories.Name = "ChkIncludeSubdirectories";
            this.ChkIncludeSubdirectories.Size = new System.Drawing.Size(142, 19);
            this.ChkIncludeSubdirectories.TabIndex = 3;
            this.ChkIncludeSubdirectories.Text = "Include subdirectories";
            this.ChkIncludeSubdirectories.UseVisualStyleBackColor = true;
            // 
            // GbxEvents
            // 
            this.GbxEvents.Controls.Add(this.ChkDeleted);
            this.GbxEvents.Controls.Add(this.ChkRenamed);
            this.GbxEvents.Controls.Add(this.ChkChanged);
            this.GbxEvents.Controls.Add(this.ChkCreated);
            this.GbxEvents.Location = new System.Drawing.Point(12, 101);
            this.GbxEvents.Name = "GbxEvents";
            this.GbxEvents.Size = new System.Drawing.Size(290, 74);
            this.GbxEvents.TabIndex = 3;
            this.GbxEvents.TabStop = false;
            this.GbxEvents.Text = "Events";
            // 
            // ChkDeleted
            // 
            this.ChkDeleted.AutoSize = true;
            this.ChkDeleted.Checked = true;
            this.ChkDeleted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkDeleted.Location = new System.Drawing.Point(114, 47);
            this.ChkDeleted.Name = "ChkDeleted";
            this.ChkDeleted.Size = new System.Drawing.Size(66, 19);
            this.ChkDeleted.TabIndex = 7;
            this.ChkDeleted.Text = "Deleted";
            this.ChkDeleted.UseVisualStyleBackColor = true;
            // 
            // ChkRenamed
            // 
            this.ChkRenamed.AutoSize = true;
            this.ChkRenamed.Checked = true;
            this.ChkRenamed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkRenamed.Location = new System.Drawing.Point(114, 22);
            this.ChkRenamed.Name = "ChkRenamed";
            this.ChkRenamed.Size = new System.Drawing.Size(76, 19);
            this.ChkRenamed.TabIndex = 6;
            this.ChkRenamed.Text = "Renamed";
            this.ChkRenamed.UseVisualStyleBackColor = true;
            // 
            // ChkChanged
            // 
            this.ChkChanged.AutoSize = true;
            this.ChkChanged.Checked = true;
            this.ChkChanged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkChanged.Location = new System.Drawing.Point(6, 47);
            this.ChkChanged.Name = "ChkChanged";
            this.ChkChanged.Size = new System.Drawing.Size(74, 19);
            this.ChkChanged.TabIndex = 5;
            this.ChkChanged.Text = "Changed";
            this.ChkChanged.UseVisualStyleBackColor = true;
            // 
            // ChkCreated
            // 
            this.ChkCreated.AutoSize = true;
            this.ChkCreated.Checked = true;
            this.ChkCreated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkCreated.Location = new System.Drawing.Point(6, 22);
            this.ChkCreated.Name = "ChkCreated";
            this.ChkCreated.Size = new System.Drawing.Size(67, 19);
            this.ChkCreated.TabIndex = 4;
            this.ChkCreated.Text = "Created";
            this.ChkCreated.UseVisualStyleBackColor = true;
            // 
            // BtSave
            // 
            this.BtSave.Location = new System.Drawing.Point(12, 181);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(142, 40);
            this.BtSave.TabIndex = 4;
            this.BtSave.Text = "Save";
            this.BtSave.UseVisualStyleBackColor = true;
            // 
            // BtCancel
            // 
            this.BtCancel.Location = new System.Drawing.Point(160, 181);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(142, 40);
            this.BtCancel.TabIndex = 5;
            this.BtCancel.Text = "Cancel";
            this.BtCancel.UseVisualStyleBackColor = true;
            // 
            // FrmAddFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 232);
            this.Controls.Add(this.BtCancel);
            this.Controls.Add(this.BtSave);
            this.Controls.Add(this.GbxEvents);
            this.Controls.Add(this.GbxOptions);
            this.Controls.Add(this.BtSearch);
            this.Controls.Add(this.TxtPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddFolder";
            this.Text = "Add Folder";
            this.GbxOptions.ResumeLayout(false);
            this.GbxOptions.PerformLayout();
            this.GbxEvents.ResumeLayout(false);
            this.GbxEvents.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtPath;
        private Button BtSearch;
        private GroupBox GbxOptions;
        private CheckBox ChkIncludeSubdirectories;
        private GroupBox GbxEvents;
        private CheckBox ChkDeleted;
        private CheckBox ChkRenamed;
        private CheckBox ChkChanged;
        private CheckBox ChkCreated;
        private Button BtSave;
        private Button BtCancel;
        private FolderBrowserDialog FolderBrowser;
    }
}