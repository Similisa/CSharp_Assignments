using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating microsoft unity container
            UnityContainer UC = new UnityContainer();

            //register all types 
            UC.RegisterType<BL>();
            UC.RegisterType<DL>();
            UC.RegisterType<IProduct, DL>();
            BL business = UC.Resolve<BL>();
            business.Insert();//BL instance method
            Console.Read();

        }
    }
}
