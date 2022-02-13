using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullFactoryPattern
{
   public abstract class CreditCardFactory
    {
        protected abstract CreditCard Makeproduct();

        public CreditCard CreateProduct()
        {
            return this.Makeproduct();
        }
    }
}
