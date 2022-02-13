using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditcard = new PlatinumFactory().CreateProduct();
            if (creditcard != null)
            {
                Console.WriteLine("CardType :" + " " + creditcard.GetCardType());
                Console.WriteLine("CreditLimit :" + " " + creditcard.GetCreditLimit()
                 Console.WriteLine("AnnualCharges :" + " " + creditcard.GetAnnualCharges()

            }
        }
    }
}
