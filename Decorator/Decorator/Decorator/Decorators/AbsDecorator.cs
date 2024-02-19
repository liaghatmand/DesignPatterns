using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public abstract class AbsDecorator : AbsComponent
    {
        protected AbsComponent _component;
        public AbsDecorator(AbsComponent component) => _component = component;
        public void SetComponent(AbsComponent component) => _component = component;
        public override string Operation()
        {
            if (_component is not null) { return _component.Operation(); }
            return string.Empty;
        }
    }
}
