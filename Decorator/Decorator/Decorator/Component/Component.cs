using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Component
{
    public class Component : AbsComponent
    {
        public override string Operation()
        {
            return "Component";
        }
    }
}
