using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullFactoryPattern
{
    class MoneyBackFactory:CreditCardFactory
    {
        protected override CreditCard Makeproduct()
        {
            CreditCard product = new MoneyBack();
            return product;
        }
    }
    class TitaniumFactory: CreditCardFactory
    {
        protected override CreditCard Makeproduct()
        {
            CreditCard product = new Titanium();
            return product;
        }
    }

    class PlatinumFactory : CreditCardFactory
    {
        protected override CreditCard Makeproduct()
        {
            CreditCard product = new platinum();
            return product;
        }
    }

}
