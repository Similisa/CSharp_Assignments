using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Feb1Prj
{
    public delegate void Prints(string s);

    public class printExample
    {
        static FileStream fs; //like a paper where something can be written
        static StreamWriter sw;  //like a pen object to write to a stream

        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The string is{0}", str);
        }

        public static void WriteToFile(string s)
        {
            fs = new FileStream("message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public static void sendstring(Prints ps)
        {
            ps("This is c# class on Delegates"); //invoking the delegates
        }
    }
    class Delegates3
    {
        static void Main()
        {
            Prints ps1 = new Prints(printExample.WriteToScreen);
            Prints ps2 = new Prints(printExample.WriteToFile);
            printExample.sendstring(ps1);
            printExample.sendstring(ps2);
            Console.Read();
        }
    }
}
