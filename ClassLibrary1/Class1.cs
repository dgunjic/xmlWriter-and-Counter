using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using WindowsFormsApplication1;

namespace ClassLibrary1
{
    public class Class1
    {
        

        public void Folder2XML(string start)
        {

            try
            {

                Folder folders = new Folder();
                string[] fileArr = Directory.GetFiles(start, "* *");
                int counter = 0;
                foreach (string file in fileArr)
                {
                    counter = file.Length - file.Replace(" ", "").Length;
                }

                folders.FolderName = System.IO.Path.GetFileName(start);
                folders.NumberOfFiles = fileArr.Length.ToString();

                foreach (string file in fileArr)
                {

                    files.FileName = System.IO.Path.GetFileName(file);
                    files.NumberOfSpaces = (" " + counter);
                    Serialize(folders + files);
                }
            }
            catch (Exception pe)
            {
                Console.WriteLine(pe.ToString());
            }
        }
        static public void Serialize(Folder folders)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(fileArr[]));
            using (TextWriter writer = new StreamWriter(@"C:\Xml.xml"))
            {
                serializer.Serialize(writer, folders);
            }
        }
        /* using (XmlTextWriter wr = new XmlTextWriter( "test.xml", Encoding.UTF8))
        {
            wr.Formatting = Formatting.Indented;
            wr.Indentation = 4;
            wr.WriteStartDocument();
            wr.WriteStartElement("Folders");
            WriteFolder(wr, start);
            wr.WriteEndElement();
            wr.WriteEndDocument();
        }
    }*/

        private void WriteFolder(XmlTextWriter wr, string start)
        {
            try {


            string[] files = Directory.GetFiles(start, "* *");
                int counter = 0;
                foreach (string file in files)
                {
                    counter = file.Length - file.Replace(" ", "").Length;
                }
            
            wr.WriteStartElement("Folder");
            wr.WriteAttributeString("FolderName", System.IO.Path.GetFileName(start));
            wr.WriteAttributeString("NumberOfFiles", files.Length.ToString());
           
            
            foreach (string file in files)
            {           
                   
                    wr.WriteStartElement("File");
                    wr.WriteAttributeString("FileName", System.IO.Path.GetFileName(file));
                    wr.WriteAttributeString("NumberOfSpaces", (" "+ counter));
                    wr.WriteEndElement();
                

            }
            string[] folders = System.IO.Directory.GetDirectories(start);
            foreach (string folder in folders)
            {
                WriteFolder(wr, folder);
            }
            wr.WriteEndElement();
            }
            catch (Exception pe)
            {
                Console.WriteLine(pe.ToString());
            }
        }
    }
}