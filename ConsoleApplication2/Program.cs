using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.IO;
using System.Xml;

namespace ConsoleApplication2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] drives = System.IO.Directory.GetLogicalDrives();

            foreach (string str in drives)
            {
                System.Console.WriteLine(str);
            }
            Console.WriteLine("Choose one drive:");
            string start = Console.ReadLine();
            
            Class1 obj =new Class1();
            obj.Folder2XML(start);
        }
    }
}
