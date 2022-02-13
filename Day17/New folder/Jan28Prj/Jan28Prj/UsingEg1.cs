using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Jan28Prj
{
    class UsingEg1
    {

        static void Main()
        {
            string multiplelines = @"This is line one
         This is Line Two
         Here comes Line 3
         Line four arrived
         Final and Fifth Line";
            using (var reader = new StringReader(multiplelines))
            {
                string item;
                do
                {
                    item = reader.ReadLine();
                    Console.WriteLine(item);
                } while (item != null);

            }
            /*using (var streamReader = new StreamReader("e:\\file1.txt")
                {
                Console.WriteLine(streamReader.ReadToEnd());
                }*/
            using (var mydisposable = new MyDisposableclass())
            {
                mydisposable.DoSomeWork();
            }
            Console.Read();
        }

    }
    public class MyDisposableclass : IDisposable
    {
        //constructor
        public MyDisposableclass()
        {
            Console.WriteLine("Allocating Resoures ");
        }
        //Normal method
        public void DoSomeWork()
        {
            Console.WriteLine("I am alloted resourse");
        }
        public void Dispose()
        {
            Console.WriteLine("Relesing Resource");
        }
    }
}