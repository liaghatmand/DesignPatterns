using AbstractFactory.MainFactory.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.FactoryB
{
    internal class ProductB2 : IProductB
    {
        public string WhatAmI()
        {
            return "Your order is ready! I Am a ProductB2";
        }
    }
}
