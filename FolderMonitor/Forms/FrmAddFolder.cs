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

        public FrmAddFolder(List<Monitoring> monitorings)
        {
            InitializeComponent();
            Monitorings = monitorings;
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

            //Create object Monitoring and add Monitoring object in Monitoring list
            Monitoring monitor = new Monitoring(path: TxtPath.Text, includeSubdirectories: ChkIncludeSubdirectories.Checked, created: ChkCreated.Checked, changed: ChkChanged.Checked, deleted: ChkDeleted.Checked, renamed: ChkRenamed.Checked);
            monitor.LoadFileSystemWatcher();
            monitor.LoadEvents();
            Monitorings.Add(monitor);

            this.Close();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
