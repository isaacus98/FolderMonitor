using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderMonitor.Class
{
    public class Monitoring
    {
        private FileSystemWatcher Watcher;
        private bool _ObjectError = false;
        public string Path { get; set; }
        public bool IncludeSubdirectories { get; set; }
        public bool Created { get; set; }
        public bool Changed { get; set; }
        public bool Deleted { get; set; }
        public bool Renamed { get; set; }
        public bool ObjectError { get => _ObjectError; }

        public Monitoring(string path, bool includeSubdirectories, bool created, bool changed, bool deleted, bool renamed)
        {
            Path = path;
            IncludeSubdirectories = includeSubdirectories;
            Created = created;
            Changed = changed;
            Deleted = deleted;
            Renamed = renamed;
        }

        public void LoadFileSystemWatcher()
        {
            try
            {
                Watcher = new FileSystemWatcher(Path)
                {
                    NotifyFilter = NotifyFilters.Attributes
                                   | NotifyFilters.CreationTime
                                   | NotifyFilters.DirectoryName
                                   | NotifyFilters.FileName
                                   | NotifyFilters.LastAccess
                                   | NotifyFilters.LastWrite
                                   | NotifyFilters.Security
                                   | NotifyFilters.Size,

                    IncludeSubdirectories = this.IncludeSubdirectories,
                    EnableRaisingEvents = true
                };
            }
            catch(ArgumentException e) 
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ObjectError = true;
            }
        }

        public void LoadEvents()
        {
            if(Watcher != null)
            {
                if (Created)
                    Watcher.Created += Watcher_Created;
                else
                    Watcher.Created -= Watcher_Created;

                if (Changed)
                    Watcher.Changed += Watcher_Changed;
                else
                    Watcher.Changed -= Watcher_Changed;

                if (Deleted)
                    Watcher.Deleted += Watcher_Deleted;
                else
                    Watcher.Deleted -= Watcher_Deleted;

                if (Renamed)
                    Watcher.Renamed += Watcher_Renamed;
                else
                    Watcher.Renamed -= Watcher_Renamed;
            }


        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            FrmMain.Notification.ShowBalloonTip(1000, "File created", $"File created in {e.FullPath}" + Environment.NewLine + $"File name: {e.Name}", ToolTipIcon.Info);
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            FrmMain.Notification.ShowBalloonTip(1000, "File changed", $"File changed in {e.FullPath}" + Environment.NewLine + $"File name: {e.Name}", ToolTipIcon.Info);
        }

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            FrmMain.Notification.ShowBalloonTip(1000, "File deleted", $"File deleted in {e.FullPath}" + Environment.NewLine + $"File name: {e.Name}", ToolTipIcon.Info);            
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            FrmMain.Notification.ShowBalloonTip(1000, "File renamed", $"File renamed in {e.FullPath}" + Environment.NewLine + $"Old file name: {e.OldName}" + Environment.NewLine + $"New file name: {e.Name}", ToolTipIcon.Info);
        }
    }
}
