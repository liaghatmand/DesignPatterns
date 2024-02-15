using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();
        public string SomeOperation() {
            IProduct product = FactoryMethod();
            string result = string.Empty;
            return  result = product.Operation();
        }

    }
}
