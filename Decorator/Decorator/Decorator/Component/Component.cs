using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Component
{
    //this is the wrapee: a class of objects being wrapped. It defines the basic behavior,
    public class Component : AbsComponent
    {
        public override string Operation()
        {
            return "Defaul Behavior";
        }
    }
}
