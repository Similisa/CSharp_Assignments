using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb3Prj
{
    class Equality2
    {
        static void Main()   
        {
             string name = "sandeep";
             string myname = name;

            Console.WriteLine("== operator result is {0}", name = myname);
            Console.WriteLine("Equals Methos result is {0}", name.Equals(myname));
            object oname = "Sandeep";
            char[] val = { 's', 'a', 'n', 'd', 'e', 'p' };
            object omyname = new string(val);
            Console.Read();
        }
       
    }
}
