using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Folder
    {
        public Folder()
        {

        }
        public Folder(string FolderName, int NumberOfFiles, List<File> files)
        {
            this.FolderName = FolderName;
            this.NumberOfFiles = NumberOfFiles;
            files = new List<File>();
        }

        public string FolderName { get; set; }
        public int NumberOfFiles { get; set; }
        
        public List<File> files = new List<File>();
    }
    
}
