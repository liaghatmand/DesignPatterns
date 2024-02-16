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
            return "I Am ProductB2";
        }
    }
}
