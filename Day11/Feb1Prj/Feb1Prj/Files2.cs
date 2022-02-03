using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Feb1Prj
{
    class Files2
    {
        public void ReadData()
        {
            FileStream fs = new FileStream("Message.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            //position the file pointer at the begining of the file
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            //Read till the end of the file
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine("{0}", str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
        public void writeData()
        {
            FileStream fs = new FileStream("Message.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            Console.WriteLine("Enter data to be Written: ");
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public void Directory_FileInfo()
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"E:\ZensarDir");
            if (dirinfo.Exists)
            {
                Console.WriteLine("Directory exists");
            }
            else
            {
                dirinfo.Create();
                Console.WriteLine("Diretory Created");
            }

            
        }
        // code to get all subdirectories
        public void GetDirectories()
        {
            DirectoryInfo mydirobj = new DirectoryInfo(@"E: Banu");

            if (mydirobj.Exists)
            {
                DirectoryInfo[] directories = mydirobj.GetDirectories();
                foreach (object dirnames in directories)
                {
                    Console.WriteLine(dirnames.ToString());
                }
            }
            else
            {
                Console.WriteLine("The geive does not exists");
            }
            //code for gettoing all files indside directories
            FileInfo[] f = mydirobj.GetFiles();
            foreach(FileInfo fle in f)
            {
                Console.WriteLine("FileName: {0} size {1}");
            }
        }
       
        static void Main()
        {
            Files2 file2 = new Files2();
            file2.ReadData();
            Console.Read();
        }
    }
}
