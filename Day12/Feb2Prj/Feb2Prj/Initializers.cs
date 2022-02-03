using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb2Prj
{
    class student
    {
        public int StudentId;
        public string StudentName;
    }
    class Initializers
    {
        static void Main()
        {
            List<student> studlist = new List<student>()
            {
                new student(){StudentId=1,StudentName="Rajesh"},
                new student(){StudentId=2,StudentName="Rakesh"},
                new student(){StudentId=3,StudentName="Sukesh"},
                null
            };
            var div = Divide(10, 0);
        }

        public static double Divide(int x, int y)
        {
            return y != 0 ? x / y : throw new DivideByZeroException();
        }
    }

}
