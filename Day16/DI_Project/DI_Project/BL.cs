using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Project
{
    class BL
    {
        private IProduct objprod;

        public BL(IProduct ip)//injecting the interface 
        {
            objprod = ip;
        }

        public void Insert()
        {
            objprod.Insertdata(); //actually the call will be for DL.InsertData(),
                                  //but through the IProduct object
        }

    }
}
