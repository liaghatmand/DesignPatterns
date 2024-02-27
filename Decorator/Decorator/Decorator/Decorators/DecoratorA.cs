using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal class DecoratorA : AbsDecorator
    {
        public DecoratorA(AbsComponent component) : base(component) { }
        public override string Operation()
        {
            return $"{base.Operation()} wrapped with DecoratorA";
        }
    }
}
