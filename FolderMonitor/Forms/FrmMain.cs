using FolderMonitor.Class;
using FolderMonitor.Forms;

namespace FolderMonitor
{
    public partial class FrmMain : Form
    {
        private List<Monitoring>? Monitorings;

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

        }

        private void BtExit_Click(object sender, EventArgs e)
        {
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