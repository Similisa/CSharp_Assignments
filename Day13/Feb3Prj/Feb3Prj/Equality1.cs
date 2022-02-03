using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb3Prj
{
    class Class1 { }

    class Class2 { }
    class Equality1
    {
        public static void Test(Object obj)
        {
            CLass1 a;
            Class2 b;
            if(obj is Class1)
            {
                Console.WriteLine("obj is class1");
                a = (Class1)obj;

            }

        }
    }
}
