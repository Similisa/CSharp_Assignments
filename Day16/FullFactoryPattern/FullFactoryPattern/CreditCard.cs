using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullFactoryPattern
{
    public  interface CreditCard
    {
        string GetCardType();
        string creditLimit();
        string GetAnnualCharges();
    }
}
