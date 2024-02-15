using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Creator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ProductB();
        }
    }
}
