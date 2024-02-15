using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Creators;
using FactoryMethod.MainFactory;

namespace FactoryMethod.FactoryB
{
    //Creates ProductB
    public class Creator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ProductB();
        }
    }
}
