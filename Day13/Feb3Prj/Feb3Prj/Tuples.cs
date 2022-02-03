using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb3Prj
{
    class Tuples
    {
        static void Main()
        {
            var values = new List<double>() { 10, 20, 30, 40, 50 };
            Tuple<int, double> t = Calculate(values);
            Console.WriteLine($"There are {t.Item1} values and their sum is{t.Item2}");
            Console.Read();
        }

        static Tuple<int, double> Calculate(IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0.0;
            foreach(var v in values)
            {
                count++;
                sum += v;
            }
        }
    }
}
