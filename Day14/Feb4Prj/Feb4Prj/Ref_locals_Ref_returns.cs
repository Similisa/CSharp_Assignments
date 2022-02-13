using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb4Prj
{
    class Ref_locals_Ref_returns
    {
        static void Main()
        {
            int num1 = 5;
            ref int num2 = ref num1;
            num2 = 8;
            Console.WriteLine($"Local variable {nameof(num1)} after the change: {num1}");


            Console.Read();
        }
    }
}
