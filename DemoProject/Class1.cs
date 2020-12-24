using LumenWorks.Framework.IO.Csv;
using NUnit.Framework;
using RectangleApplication;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DemoProject
{
    class Class1
    {

        private string xmlFileName;
        private object driver;
        private string workingFiles;
        private int number;

        public bool Justin { get; private set; }

        [Test]
        public void PraciceMethod() {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
        }


        [Test]
        public void PraciceMethod1()
        {
            Console.WriteLine("Hello World");
            TestContext.WriteLine("Hello World");
        }


        [Test]
        public void xmlReader()
        {
            string xmlFileName = "Constants.xml";
            // string dir = System.IO.Path.GetDirectoryName(this.Host.TemplateFile);

            string xmlPath = Path.Combine("C:\\temp\\DemoProject\\demoproject\\" + xmlFileName);
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);

            foreach (XmlNode node in doc.ChildNodes[0].ChildNodes)
            {
                XmlNode cName = node.SelectSingleNode("Name");
                XmlNode cType = node.SelectSingleNode("Type");
                XmlNode cValue = node.SelectSingleNode("Value");
                TestContext.WriteLine(cName.InnerText);
                TestContext.WriteLine(cType.InnerText);
                TestContext.WriteLine(cValue.InnerText);
            }

        }
           
    
        [Test]
        public void TableMultiply()
        {
            int number, multiply;
            {

                TestContext.WriteLine("Enter the Table Number");
                number = 3;

                for (multiply = 1; multiply <= 10; multiply++)
                {
                    TestContext.WriteLine("{0} * {1} = {2}", number, multiply, (number * multiply));
                }

            }
        }


        [Test]
        public void FolderList()
        {
            FoldersInDirectory(@"D:\");
        }   

        private void FoldersInDirectory(string workingDirectory)
        {
                string[] folderPaths = Directory.GetDirectories(workingDirectory);


                foreach (string folderPath in folderPaths)
                {
                    TestContext.WriteLine(folderPath);
                }
        }


        [Test]
        public void FileList()
        {
            FoldersInDirectory(@"D:\");
        }

        private void FilesInDirectory(string workingDirectory)
        {
            string[] filePaths = Directory.GetFiles(workingFiles);


                foreach (string filePath in filePaths)
                {
                    Console.WriteLine(filePath);
                }
        }

        
        
        // ------------ Loop -------------- //


        [Test]

        public void forloop()
        {
          for (int x = 1; x <= 10; x++)
          {
                TestContext.WriteLine("Number is " + x);
          }
         
        }


        [Test]

        public void whileloop()
        {
            int x = 1;

            while (x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }
        }

        
        [Test]

        public void dowhileloop()
        {
            int x = 1;

            do
            {
                TestContext.WriteLine(x);
                x++;
            } while (x > 10);

        }


        [Test]

        public void foreachloop()
        {
            string name = "Justin";

            foreach (char s in name)
            {
                Console.WriteLine(s);
            }
        }


        // ------------ Loop Excerxises -------- //

        [Test]

        public void Loopdemo1()
        {
            int a;

            for (a = 1; a <= 10; a++)
            {
                //Space in Numbers print//
                TestContext.Write("{0} ", a);

            }

        }

        [Test]

        public void LoopdemoAdd()
        {
            int j, sum = 0;

            for (j = 1; j <= 10; j++)
            {
                sum = sum + j;
                TestContext.Write("{0} ", j);
            }
            TestContext.Write("\n Sum is : {0}\n", sum);
        }


        [Test]

        public void StarPrint()
        {
            int i, j, rows;
           
            rows = 10;

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    TestContext.Write("*");
                    TestContext.Write("\n");
            }

        }


        [Test]

        public void NumbrPrint()
        {
            int i, j, rows;

            rows = 5;

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    TestContext.Write("{0}", j);
                    TestContext.Write("\n");
            }
        }


        [Test]

        public void NumbrPrintPattern()
        {
            int i, j, rows, k = 1;

            rows = 5;

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    TestContext.Write("{0} ", k++);
                TestContext.Write("\n");
            }

        }






    }
}
