using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal class DecoratorB : AbsDecorator
    {
        public DecoratorB(AbsComponent component) : base(component)
        {
        }
        public override string Operation()
        {
            return $"DecoratorB({base.Operation()})";
        }
    }
}
