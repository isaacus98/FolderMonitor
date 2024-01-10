using FolderMonitor.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderMonitor.Forms
{
    public partial class FrmAddFolder : Form
    {
        private List<Monitoring> Monitorings;
        private int Index = -1;
        private bool IsEdit;

        public FrmAddFolder(List<Monitoring> monitorings)
        {
            InitializeComponent();
            Monitorings = monitorings;
            IsEdit = false;
        }

        public FrmAddFolder(List<Monitoring> monitorings, int index)
        {
            InitializeComponent();
            Monitorings= monitorings;
            Index = index;
            IsEdit= true;
        }

        private void FrmAddFolder_Load(object sender, EventArgs e)
        {
            if (Index != -1)
            {
                TxtPath.Text = Monitorings[Index].Path;
                ChkIncludeSubdirectories.Checked = Monitorings[Index].IncludeSubdirectories;
                ChkCreated.Checked = Monitorings[Index].Created;
                ChkChanged.Checked = Monitorings[Index].Changed;
                ChkDeleted.Checked = Monitorings[Index].Deleted;
                ChkRenamed.Checked = Monitorings[Index].Renamed;
            }
        }

        private void BtSearch_Click(object sender, EventArgs e)
        {
            if(FolderBrowser.ShowDialog() == DialogResult.OK)
                TxtPath.Text = FolderBrowser.SelectedPath;
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            //Check if textbox is empty
            if (string.IsNullOrWhiteSpace(TxtPath.Text))
            {
                MessageBox.Show("The folder path is still to be selected", "Folder monitor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Check if directoryExist
            if (!Directory.Exists(TxtPath.Text))
            {
                MessageBox.Show("Folder path does not exist", "Folder monitor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //check if directory is already being monitored
            foreach(Monitoring monitoring in Monitorings)
            {
                if (monitoring.Path == TxtPath.Text)
                {
                    MessageBox.Show("This folder is already being monitored", "Folder monitor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (IsEdit)
            {
                //Edit Monitoring object in Monitoring list
                Monitorings[Index].Path = TxtPath.Text;
                Monitorings[Index].IncludeSubdirectories = ChkIncludeSubdirectories.Checked;
                Monitorings[Index].Created = ChkCreated.Checked;
                Monitorings[Index].Changed = ChkChanged.Checked;
                Monitorings[Index].Deleted = ChkDeleted.Checked;
                Monitorings[Index].Renamed = ChkRenamed.Checked;
                Monitorings[Index].LoadFileSystemWatcher();
                Monitorings[Index].LoadEvents();
            }
            else
            {
                //Create Monitoring object and add Monitoring object in Monitoring list
                Monitoring monitor = new Monitoring(path: TxtPath.Text, includeSubdirectories: ChkIncludeSubdirectories.Checked, created: ChkCreated.Checked, changed: ChkChanged.Checked, deleted: ChkDeleted.Checked, renamed: ChkRenamed.Checked);
                monitor.LoadFileSystemWatcher();
                monitor.LoadEvents();
                Monitorings.Add(monitor);
            }

            this.Close();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
