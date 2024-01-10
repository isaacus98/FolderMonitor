using FolderMonitor.Class;
using FolderMonitor.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;

namespace FolderMonitor
{
    public partial class FrmMain : Form
    {
        public static NotifyIcon Notification;
        private List<Monitoring> Monitorings;
        private string PathFolder = @"C:\Users\" + Environment.UserName + @"\AppData\Local\FolderMonitor";
        private RegistryKey Key;

        public FrmMain()
        {
            InitializeComponent();
            Notification = Notify;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DialogResult result;

            Key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            Object obj = Key.GetValue("FolderMonitor");
            if (obj == null)
                BtOpenWithWindows.Checked = false;
            else
                BtOpenWithWindows.Checked = true;

            //Load configuration file
            if (Directory.Exists(PathFolder))
            {
                if(File.Exists(PathFolder + @"\config.json"))
                {
                    Monitorings = JsonConvert.DeserializeObject<List<Monitoring>>(File.ReadAllText(PathFolder + @"\config.json"));

                    for(int i = 0; i < Monitorings.Count; i++)
                    {
                        //Load FileSystemWatcher
                        Monitorings[i].LoadFileSystemWatcher();

                        //Delete object from list if path not exist
                        if (Monitorings[i].ObjectError)
                        {
                            result = MessageBox.Show($"{Monitorings[i].Path} not exist." + Environment.NewLine + $"Do you want deleted the monitored folder in '{Monitorings[i].Path}'?", "Delete monitored folder", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if(result == DialogResult.Yes)
                                Monitorings.RemoveAt(i);
                        }
                        else
                        {
                            Monitorings[i].LoadEvents();

                            //Load data in datagridview
                            int index = DgvFolders.Rows.Add();
                            DgvFolders.Rows[index].Cells[0].Value = Monitorings[i].Path;
                        }
                    }
                }
                else
                {
                    Monitorings = new List<Monitoring>();
                }
            }
            else
            {
                Monitorings = new List<Monitoring>();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void BtAddFolder_Click(object sender, EventArgs e)
        {
            FrmAddFolder frm = new FrmAddFolder(Monitorings);
            frm.ShowDialog();

            RefreshDatagrid();
        }

        private void BtDeleteFolder_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string folderName;
            string[] pathElements;
            try
            {
                pathElements = DgvFolders.CurrentRow.Cells[0].Value.ToString().Split();
                folderName = pathElements[^1];

                result = MessageBox.Show($"Are you sure you want to remove the monitoring of the '{folderName}' folder?", "Remove folder monitoring", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                //Delete element from list and datagrid
                if(result == DialogResult.Yes)
                {
                    Monitorings.RemoveAt(DgvFolders.CurrentRow.Index);
                    DgvFolders.Rows.RemoveAt(DgvFolders.CurrentRow.Index);
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Error deleting the folder being monitored. The monitored folder will not be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            string json;
            
            //Serialize object
            Directory.CreateDirectory(PathFolder);
            json = JsonConvert.SerializeObject(Monitorings, Formatting.Indented);
            File.WriteAllText(PathFolder + @"\config.json", json);

            Environment.Exit(0);
        }

        private void BtAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            frm.ShowDialog();
        }

        private void BtOpen_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void BtActivate_Click(object sender, EventArgs e)
        {
            int index = DgvFolders.CurrentRow.Index;
            Monitorings[index].LoadFileSystemWatcher();
            Monitorings[index].LoadEvents();
        }

        private void BtOptions_Click(object sender, EventArgs e)
        {
            FrmAddFolder frm = new FrmAddFolder(Monitorings, DgvFolders.CurrentRow.Index);
            frm.ShowDialog();

            RefreshDatagrid();
        }

        private void RefreshDatagrid()
        {
            int index;
            //Refresh datagrid
            DgvFolders.Rows.Clear();
            foreach (Monitoring monitoring in Monitorings)
            {
                index = DgvFolders.Rows.Add();
                DgvFolders.Rows[index].Cells[0].Value = monitoring.Path;
            }
        }

        private void BtOpenWithWindows_Click(object sender, EventArgs e)
        {
            if (BtOpenWithWindows.Checked)
                Key.SetValue("FolderMonitor", Application.ExecutablePath);
            else
                Key.DeleteValue("FolderMonitor");
        }
    }
}