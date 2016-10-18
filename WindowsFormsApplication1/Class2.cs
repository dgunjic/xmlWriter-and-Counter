using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class File
    {
        public File()
        {
            
        }
        public File(string FileName, int NumberOfSpaces)
        {
            this.FileName = FileName;
            this.NumberOfSpaces = NumberOfSpaces;
        }

        public string FileName { get; set; }
        public int NumberOfSpaces { get; set; }
    }
}
