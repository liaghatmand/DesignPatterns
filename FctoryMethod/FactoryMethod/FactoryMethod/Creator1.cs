using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Creator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ProductA();
        }
    }
}
