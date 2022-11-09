using FolderMonitor.Class;
using FolderMonitor.Forms;
using Newtonsoft.Json;

namespace FolderMonitor
{
    public partial class FrmMain : Form
    {
        private List<Monitoring> Monitorings;
        private string PathFolder = @"C:\Users\" + Environment.UserName + @"\AppData\Local\FolderMonitor";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Monitorings = new List<Monitoring>();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void BtAddFolder_Click(object sender, EventArgs e)
        {
            int index;

            FrmAddFolder frm = new FrmAddFolder(Monitorings);
            frm.ShowDialog();

            //Refresh datagrid
            DgvFolders.Rows.Clear();
            foreach(Monitoring monitoring in Monitorings)
            {
                index = DgvFolders.Rows.Add();
                DgvFolders.Rows[index].Cells[0].Value = monitoring.Path;
            }
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
            
            Directory.CreateDirectory(PathFolder);
            json = JsonConvert.SerializeObject(Monitorings, Formatting.Indented);
            File.Create(PathFolder);

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
    }
}