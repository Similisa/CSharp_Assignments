using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb1Prj
{
    class Program
    {
        
        delegate void Print(int val);
        static void Main(string[] args)
        {
            //Anonymous Method
            Print p = delegate (int x) { Console.WriteLine("Inside Anonymous method.value{0}", x); };
            p(100);
            Print p1 = new Print(Sample);
            p1(200);
            Console.Read();
        }

        public static void Sample(int c)
        {
            Console.WriteLine(c);
            testfunc();
        }
        public static void testfunc()
        {
            Console.WriteLine("Inside Testing");
        }
    }
}
