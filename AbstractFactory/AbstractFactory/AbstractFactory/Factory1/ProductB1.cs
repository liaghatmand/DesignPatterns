using AbstractFactory.MainFactory.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.FactoryA
{
    internal class ProductB1 : IProductB
    {
        public string WhatAmI()
        {
            return "Your order is ready! I Am a ProductB1";
        }
    }
}
