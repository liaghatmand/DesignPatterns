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
            return "I Am ProductB1";
        }
    }
}
