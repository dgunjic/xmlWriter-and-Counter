using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml.Linq;
using WindowsFormsApplication1.Properties;
using System.IO;
using System.Xml;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private object LibraryView;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            XmlSerializer deserializer = new XmlSerializer(typeof(Folder));
            TextReader reader = new StreamReader("\\Users\\DiDiDiL\\Documents\\Visual Studio 2015\\Projects\\Counter2\\ConsoleApplication2\\bin\\Debug\\test.xml");
            object obj = deserializer.Deserialize(reader);
            Folder XmlData = (Folder)obj;
            reader.Close();
            listBox1.Items.Add(XmlData);

            /* XmlDocument xdoc = new XmlDocument();
             xdoc.Load("\\Users\\DiDiDiL\\Documents\\Visual Studio 2015\\Projects\\Counter2\\ConsoleApplication2\\bin\\Debug\\test.xml");

             foreach(XmlNode item in xdoc.DocumentElement)
             {
                 string FolderName = item.Attributes["FolderName"].Value;
                 int NumberOfFiles = int.Parse(item.Attributes["NumberOfFiles"].Value);
                 string FileName = item.Attributes["FileName"].Value;
                 int NumberOfSpaces = int.Parse(item.Attributes["FolderName"].Value);

                 listBox1.Items.Add(new Folder(FolderName, NumberOfFiles, files);
                 listBox1.Items.Add(new File(FileName, NumberOfSpaces));
             }*/
            /* using (XmlReader reader = XmlReader.Create("\\Users\\DiDiDiL\\Documents\\Visual Studio 2015\\Projects\\Counter2\\ConsoleApplication2\\bin\\Debug\\test.xml"))
             {
                 while (reader.Read())
                 {



                     XElement res = XElement.Load("\\Users\\DiDiDiL\\Documents\\Visual Studio 2015\\Projects\\Counter2\\ConsoleApplication2\\bin\\Debug\\test.xml");// "<Folder> <File> </File> </Folder>", LoadOptions.None);

                     dataGridView1.DataSource = res.ToString();

                 }
             }*/




        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
