using AbstractFactory.FactoryA;
using AbstractFactory.MainFactory;
using AbstractFactory.MainFactory.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.FactoryB
{
    public class Creator2 : ICreator
    {
        public IProductA CreateProductA()
        {
            return new ProductA2();
        }

        public IProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
