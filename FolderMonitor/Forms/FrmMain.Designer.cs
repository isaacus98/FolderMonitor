namespace FolderMonitor
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.Gbx = new System.Windows.Forms.GroupBox();
            this.DgvFolders = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.BtAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.BtDeleteFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.BtExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.BtAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ColDirectoryPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.BtAbout2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtExit2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.Gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFolders)).BeginInit();
            this.Menu.SuspendLayout();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbx
            // 
            this.Gbx.Controls.Add(this.DgvFolders);
            this.Gbx.Location = new System.Drawing.Point(12, 27);
            this.Gbx.Name = "Gbx";
            this.Gbx.Size = new System.Drawing.Size(776, 411);
            this.Gbx.TabIndex = 1;
            this.Gbx.TabStop = false;
            this.Gbx.Text = "Monitored folders";
            // 
            // DgvFolders
            // 
            this.DgvFolders.AllowUserToAddRows = false;
            this.DgvFolders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvFolders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvFolders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFolders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDirectoryPath});
            this.DgvFolders.Location = new System.Drawing.Point(6, 22);
            this.DgvFolders.MultiSelect = false;
            this.DgvFolders.Name = "DgvFolders";
            this.DgvFolders.ReadOnly = true;
            this.DgvFolders.RowHeadersVisible = false;
            this.DgvFolders.RowTemplate.Height = 25;
            this.DgvFolders.Size = new System.Drawing.Size(764, 383);
            this.DgvFolders.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.Window;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuHelp});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 24);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "Menu";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtAddFolder,
            this.BtDeleteFolder,
            this.BtExit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "File";
            // 
            // BtAddFolder
            // 
            this.BtAddFolder.Image = global::FolderMonitor.Properties.Resources.AddFolder;
            this.BtAddFolder.Name = "BtAddFolder";
            this.BtAddFolder.Size = new System.Drawing.Size(180, 22);
            this.BtAddFolder.Text = "Add folder";
            // 
            // BtDeleteFolder
            // 
            this.BtDeleteFolder.Image = global::FolderMonitor.Properties.Resources.DeleteFolder;
            this.BtDeleteFolder.Name = "BtDeleteFolder";
            this.BtDeleteFolder.Size = new System.Drawing.Size(180, 22);
            this.BtDeleteFolder.Text = "Delete folder";
            // 
            // BtExit
            // 
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(180, 22);
            this.BtExit.Text = "Exit";
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtAbout});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuHelp.Text = "Help";
            // 
            // BtAbout
            // 
            this.BtAbout.Image = global::FolderMonitor.Properties.Resources.About;
            this.BtAbout.Name = "BtAbout";
            this.BtAbout.Size = new System.Drawing.Size(180, 22);
            this.BtAbout.Text = "About";
            // 
            // ColDirectoryPath
            // 
            this.ColDirectoryPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColDirectoryPath.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColDirectoryPath.HeaderText = "Directory path";
            this.ColDirectoryPath.Name = "ColDirectoryPath";
            this.ColDirectoryPath.ReadOnly = true;
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtOpen,
            this.BtAbout2,
            this.BtExit2});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(108, 70);
            // 
            // BtOpen
            // 
            this.BtOpen.Name = "BtOpen";
            this.BtOpen.Size = new System.Drawing.Size(107, 22);
            this.BtOpen.Text = "Open";
            // 
            // BtAbout2
            // 
            this.BtAbout2.Name = "BtAbout2";
            this.BtAbout2.Size = new System.Drawing.Size(107, 22);
            this.BtAbout2.Text = "About";
            // 
            // BtExit2
            // 
            this.BtExit2.Name = "BtExit2";
            this.BtExit2.Size = new System.Drawing.Size(107, 22);
            this.BtExit2.Text = "Exit";
            // 
            // Notify
            // 
            this.Notify.ContextMenuStrip = this.ContextMenu;
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Visible = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gbx);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Folder Monitor";
            this.Gbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFolders)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox Gbx;
        private DataGridView DgvFolders;
        private DataGridViewTextBoxColumn ColDirectoryPath;
        private MenuStrip Menu;
        private ToolStripMenuItem MenuFile;
        private ToolStripMenuItem BtAddFolder;
        private ToolStripMenuItem BtDeleteFolder;
        private ToolStripMenuItem BtExit;
        private ToolStripMenuItem MenuHelp;
        private ToolStripMenuItem BtAbout;
        private ContextMenuStrip ContextMenu;
        private ToolStripMenuItem BtOpen;
        private ToolStripMenuItem BtAbout2;
        private ToolStripMenuItem BtExit2;
        private NotifyIcon Notify;
    }
}