using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.MainFactory;

namespace FactoryMethod.Creators
{
    public abstract class Creator
    {
        //Has the FactoryMethod which creates any kind of product
        //Has the SomeOperation method wich calls on to FactoryMethod
            //to create a product and do some operation on it.
        public abstract IProduct FactoryMethod();
        public string SomeOperation()
        {
            IProduct product = FactoryMethod();
            string result = string.Empty;
            return result = product.Operation();
        }

    }
}
