using AbstractFactory.MainFactory.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.MainFactory
{
    public interface ICreator
    {
        public  IProductA CreateProductA();
        public  IProductB CreateProductB();
    }
}