using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb4Prj
{
    class Iterators
    {
        public static IEnumerable<string>GetList()
        {
            List<string> mylst = new List<string>()
            {
              "Apples",
               "oranges",
                "Grapes"
            };

            foreach (var items in mylst)
            {

                yield return items;
            }
        }
       

            
           
    }
}
