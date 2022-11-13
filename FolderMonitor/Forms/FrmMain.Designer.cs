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
            this.ColDirectoryPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuDatagrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtAddFolder2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtDeleteFolder2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtActivate = new System.Windows.Forms.ToolStripMenuItem();
            this.BtOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.BtAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.BtDeleteFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.BtExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.BtAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.BtAbout2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtExit2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.Gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFolders)).BeginInit();
            this.ContextMenuDatagrid.SuspendLayout();
            this.Menu.SuspendLayout();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbx
            // 
            this.Gbx.Controls.Add(this.DgvFolders);
            this.Gbx.Location = new System.Drawing.Point(14, 36);
            this.Gbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gbx.Name = "Gbx";
            this.Gbx.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gbx.Size = new System.Drawing.Size(887, 548);
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
            this.DgvFolders.ContextMenuStrip = this.ContextMenuDatagrid;
            this.DgvFolders.Location = new System.Drawing.Point(7, 29);
            this.DgvFolders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvFolders.MultiSelect = false;
            this.DgvFolders.Name = "DgvFolders";
            this.DgvFolders.ReadOnly = true;
            this.DgvFolders.RowHeadersVisible = false;
            this.DgvFolders.RowHeadersWidth = 51;
            this.DgvFolders.RowTemplate.ContextMenuStrip = this.ContextMenuDatagrid;
            this.DgvFolders.RowTemplate.Height = 25;
            this.DgvFolders.Size = new System.Drawing.Size(873, 511);
            this.DgvFolders.TabIndex = 0;
            // 
            // ColDirectoryPath
            // 
            this.ColDirectoryPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColDirectoryPath.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColDirectoryPath.HeaderText = "Directory path";
            this.ColDirectoryPath.MinimumWidth = 6;
            this.ColDirectoryPath.Name = "ColDirectoryPath";
            this.ColDirectoryPath.ReadOnly = true;
            this.ColDirectoryPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ContextMenuDatagrid
            // 
            this.ContextMenuDatagrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuDatagrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtAddFolder2,
            this.BtDeleteFolder2,
            this.BtActivate,
            this.BtOptions});
            this.ContextMenuDatagrid.Name = "ContextMenuDatagrid";
            this.ContextMenuDatagrid.Size = new System.Drawing.Size(215, 136);
            // 
            // BtAddFolder2
            // 
            this.BtAddFolder2.Image = global::FolderMonitor.Properties.Resources.AddFolder;
            this.BtAddFolder2.Name = "BtAddFolder2";
            this.BtAddFolder2.Size = new System.Drawing.Size(214, 26);
            this.BtAddFolder2.Text = "Add folder";
            this.BtAddFolder2.Click += new System.EventHandler(this.BtAddFolder_Click);
            // 
            // BtDeleteFolder2
            // 
            this.BtDeleteFolder2.Image = global::FolderMonitor.Properties.Resources.DeleteFolder;
            this.BtDeleteFolder2.Name = "BtDeleteFolder2";
            this.BtDeleteFolder2.Size = new System.Drawing.Size(214, 26);
            this.BtDeleteFolder2.Text = "Delete folder";
            this.BtDeleteFolder2.Click += new System.EventHandler(this.BtDeleteFolder_Click);
            // 
            // BtActivate
            // 
            this.BtActivate.Name = "BtActivate";
            this.BtActivate.Size = new System.Drawing.Size(214, 26);
            this.BtActivate.Text = "Activate";
            this.BtActivate.ToolTipText = "Enable folder monitoring if not already enabled";
            this.BtActivate.Click += new System.EventHandler(this.BtActivate_Click);
            // 
            // BtOptions
            // 
            this.BtOptions.Name = "BtOptions";
            this.BtOptions.Size = new System.Drawing.Size(214, 26);
            this.BtOptions.Text = "Options";
            this.BtOptions.Click += new System.EventHandler(this.BtOptions_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.Window;
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuHelp});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.Menu.Size = new System.Drawing.Size(914, 30);
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
            this.MenuFile.Size = new System.Drawing.Size(46, 24);
            this.MenuFile.Text = "File";
            // 
            // BtAddFolder
            // 
            this.BtAddFolder.Image = global::FolderMonitor.Properties.Resources.AddFolder;
            this.BtAddFolder.Name = "BtAddFolder";
            this.BtAddFolder.Size = new System.Drawing.Size(180, 26);
            this.BtAddFolder.Text = "Add folder";
            this.BtAddFolder.Click += new System.EventHandler(this.BtAddFolder_Click);
            // 
            // BtDeleteFolder
            // 
            this.BtDeleteFolder.Image = global::FolderMonitor.Properties.Resources.DeleteFolder;
            this.BtDeleteFolder.Name = "BtDeleteFolder";
            this.BtDeleteFolder.Size = new System.Drawing.Size(180, 26);
            this.BtDeleteFolder.Text = "Delete folder";
            this.BtDeleteFolder.Click += new System.EventHandler(this.BtDeleteFolder_Click);
            // 
            // BtExit
            // 
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(180, 26);
            this.BtExit.Text = "Exit";
            this.BtExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtAbout});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(55, 24);
            this.MenuHelp.Text = "Help";
            // 
            // BtAbout
            // 
            this.BtAbout.Image = global::FolderMonitor.Properties.Resources.About;
            this.BtAbout.Name = "BtAbout";
            this.BtAbout.Size = new System.Drawing.Size(236, 26);
            this.BtAbout.Text = "About Folder monitor";
            this.BtAbout.Click += new System.EventHandler(this.BtAbout_Click);
            // 
            // ContextMenu
            // 
            this.ContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtOpen,
            this.BtAbout2,
            this.BtExit2});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(120, 76);
            // 
            // BtOpen
            // 
            this.BtOpen.Name = "BtOpen";
            this.BtOpen.Size = new System.Drawing.Size(119, 24);
            this.BtOpen.Text = "Open";
            this.BtOpen.Click += new System.EventHandler(this.BtOpen_Click);
            // 
            // BtAbout2
            // 
            this.BtAbout2.Name = "BtAbout2";
            this.BtAbout2.Size = new System.Drawing.Size(119, 24);
            this.BtAbout2.Text = "About";
            this.BtAbout2.Click += new System.EventHandler(this.BtAbout_Click);
            // 
            // BtExit2
            // 
            this.BtExit2.Name = "BtExit2";
            this.BtExit2.Size = new System.Drawing.Size(119, 24);
            this.BtExit2.Text = "Exit";
            this.BtExit2.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // Notify
            // 
            this.Notify.ContextMenuStrip = this.ContextMenu;
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Visible = true;
            this.Notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Notify_MouseDoubleClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.Gbx);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Folder Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Gbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFolders)).EndInit();
            this.ContextMenuDatagrid.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox Gbx;
        private DataGridView DgvFolders;
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
        private ContextMenuStrip ContextMenuDatagrid;
        private ToolStripMenuItem BtAddFolder2;
        private ToolStripMenuItem BtDeleteFolder2;
        private ToolStripMenuItem BtActivate;
        private ToolStripMenuItem BtOptions;
        private DataGridViewTextBoxColumn ColDirectoryPath;
    }
}