using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan28Prj
{
    class StaticEg
    {
        //let us declare and use the static Data member

        private static int val1 = 5;

        public static int Value
        {
            get { return val1; }
        }

        public static void printVal()
        {
            Console.WriteLine("StaticEg Class.val1" + " " + val1);
        }
    }
    class StaticEg2
    {
        private static int val1;

        //static onstructor

        static StaticEg2()
        {
            if (StaticEg2.val1 < 10)
            {
                val1 = 25;
            }
            else
            {
                val1 = 100;
            }
            Console.WriteLine("Static COnstructor for classs StaticEg2 called...");
        }

        public static void print()
        {
            Console.WriteLine("StaticEg2 Class.val1" + " " + val1);
        }

        static void Main()
        {
            StaticEg.printVal();
            print();
            Console.Read();
        }
    }
}
