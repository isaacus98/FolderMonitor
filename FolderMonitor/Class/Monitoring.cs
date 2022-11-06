using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderMonitor.Class
{
    public class Monitoring
    {
        private FileSystemWatcher? Watcher;
        public string Path { get; set; }
        public bool IncludeSubdirectories { get; set; }
        public bool Created { get; set; }
        public bool Changed { get; set; }
        public bool Deleted { get; set; }
        public bool Renamed { get; set; }

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
            
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            
        }

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            
        }
    }
}
