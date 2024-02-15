using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Creators;
using FactoryMethod.FactoryA;
using FactoryMethod.FactoryB;
namespace FactoryMethod.Client
{
    class Client
    {
        //this class can choose to use any factory it wants
            //to create any kind of object that factory produces
        public void Main()
        {
            ClientCode(new Creator1());

            Console.WriteLine("");

            ClientCode(new Creator2());
        }
        public void ClientCode(Creator creator)
        {
            Console.WriteLine(@"Client: I'm not aware of the creator's class,
                but it still works.\n" + creator.SomeOperation());
        }
    }
}
