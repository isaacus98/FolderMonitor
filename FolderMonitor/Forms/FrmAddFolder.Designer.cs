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
            this.TxtPath.Location = new System.Drawing.Point(14, 16);
            this.TxtPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.PlaceholderText = "Folder path";
            this.TxtPath.Size = new System.Drawing.Size(297, 27);
            this.TxtPath.TabIndex = 0;
            // 
            // BtSearch
            // 
            this.BtSearch.Location = new System.Drawing.Point(318, 15);
            this.BtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.Size = new System.Drawing.Size(27, 32);
            this.BtSearch.TabIndex = 1;
            this.BtSearch.Text = "...";
            this.BtSearch.UseVisualStyleBackColor = true;
            this.BtSearch.Click += new System.EventHandler(this.BtSearch_Click);
            // 
            // GbxOptions
            // 
            this.GbxOptions.Controls.Add(this.ChkIncludeSubdirectories);
            this.GbxOptions.Location = new System.Drawing.Point(14, 55);
            this.GbxOptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbxOptions.Name = "GbxOptions";
            this.GbxOptions.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbxOptions.Size = new System.Drawing.Size(331, 72);
            this.GbxOptions.TabIndex = 2;
            this.GbxOptions.TabStop = false;
            this.GbxOptions.Text = "Options";
            // 
            // ChkIncludeSubdirectories
            // 
            this.ChkIncludeSubdirectories.AutoSize = true;
            this.ChkIncludeSubdirectories.Checked = true;
            this.ChkIncludeSubdirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkIncludeSubdirectories.Location = new System.Drawing.Point(7, 29);
            this.ChkIncludeSubdirectories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChkIncludeSubdirectories.Name = "ChkIncludeSubdirectories";
            this.ChkIncludeSubdirectories.Size = new System.Drawing.Size(176, 24);
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
            this.GbxEvents.Location = new System.Drawing.Point(14, 135);
            this.GbxEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbxEvents.Name = "GbxEvents";
            this.GbxEvents.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbxEvents.Size = new System.Drawing.Size(331, 99);
            this.GbxEvents.TabIndex = 3;
            this.GbxEvents.TabStop = false;
            this.GbxEvents.Text = "Events";
            // 
            // ChkDeleted
            // 
            this.ChkDeleted.AutoSize = true;
            this.ChkDeleted.Checked = true;
            this.ChkDeleted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkDeleted.Location = new System.Drawing.Point(130, 63);
            this.ChkDeleted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChkDeleted.Name = "ChkDeleted";
            this.ChkDeleted.Size = new System.Drawing.Size(84, 24);
            this.ChkDeleted.TabIndex = 7;
            this.ChkDeleted.Text = "Deleted";
            this.ChkDeleted.UseVisualStyleBackColor = true;
            // 
            // ChkRenamed
            // 
            this.ChkRenamed.AutoSize = true;
            this.ChkRenamed.Checked = true;
            this.ChkRenamed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkRenamed.Location = new System.Drawing.Point(130, 29);
            this.ChkRenamed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChkRenamed.Name = "ChkRenamed";
            this.ChkRenamed.Size = new System.Drawing.Size(94, 24);
            this.ChkRenamed.TabIndex = 6;
            this.ChkRenamed.Text = "Renamed";
            this.ChkRenamed.UseVisualStyleBackColor = true;
            // 
            // ChkChanged
            // 
            this.ChkChanged.AutoSize = true;
            this.ChkChanged.Checked = true;
            this.ChkChanged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkChanged.Location = new System.Drawing.Point(7, 63);
            this.ChkChanged.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChkChanged.Name = "ChkChanged";
            this.ChkChanged.Size = new System.Drawing.Size(90, 24);
            this.ChkChanged.TabIndex = 5;
            this.ChkChanged.Text = "Changed";
            this.ChkChanged.UseVisualStyleBackColor = true;
            // 
            // ChkCreated
            // 
            this.ChkCreated.AutoSize = true;
            this.ChkCreated.Checked = true;
            this.ChkCreated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkCreated.Location = new System.Drawing.Point(7, 29);
            this.ChkCreated.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChkCreated.Name = "ChkCreated";
            this.ChkCreated.Size = new System.Drawing.Size(83, 24);
            this.ChkCreated.TabIndex = 4;
            this.ChkCreated.Text = "Created";
            this.ChkCreated.UseVisualStyleBackColor = true;
            // 
            // BtSave
            // 
            this.BtSave.Location = new System.Drawing.Point(14, 241);
            this.BtSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(162, 53);
            this.BtSave.TabIndex = 4;
            this.BtSave.Text = "Save";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // BtCancel
            // 
            this.BtCancel.Location = new System.Drawing.Point(183, 241);
            this.BtCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(162, 53);
            this.BtCancel.TabIndex = 5;
            this.BtCancel.Text = "Cancel";
            this.BtCancel.UseVisualStyleBackColor = true;
            this.BtCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // FrmAddFolder
            // 
            this.AcceptButton = this.BtSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtCancel;
            this.ClientSize = new System.Drawing.Size(358, 309);
            this.Controls.Add(this.BtCancel);
            this.Controls.Add(this.BtSave);
            this.Controls.Add(this.GbxEvents);
            this.Controls.Add(this.GbxOptions);
            this.Controls.Add(this.BtSearch);
            this.Controls.Add(this.TxtPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddFolder";
            this.Text = "Add Folder";
            this.Load += new System.EventHandler(this.FrmAddFolder_Load);
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