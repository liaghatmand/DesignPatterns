using AbstractFactory.MainFactory.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.FactoryB
{
    public class ProductA2 : IProductA
    {
        public string WhatAmI()
        {
            return "I Am ProductA2";
        }
    }
}
