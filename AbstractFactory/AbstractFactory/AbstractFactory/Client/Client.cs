using AbstractFactory.FactoryA;
using AbstractFactory.FactoryB;
using AbstractFactory.MainFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Client
{
    public class Client
    {
        public void main() 
        {
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new Creator1());
            Console.WriteLine();

            Console.WriteLine(@"Client: Testing the same client code with the 
                second factory type...");
            ClientMethod(new Creator2());
        }
        public void ClientMethod(ICreator factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productA.WhatAmI());
            Console.WriteLine(productB.WhatAmI());
        }
    }
}
