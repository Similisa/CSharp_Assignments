﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb2Prj
{
    class QueryExpression
    {
        static void Main()
        {
            int[] numbers = { 7, 99, 45, 53,51,89 };
            int[] val = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //query Expression
            var res=from n in numbers
                    where n>50
                    orderby n
                    select n.ToString();

            foreach(var item in res)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
