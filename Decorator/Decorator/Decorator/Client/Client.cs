using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Client
{
    public class Client
    {
        public void ClientCode(AbsComponent component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}
