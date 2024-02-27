using Decorator.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    //The Base Decorator class has a field for referencing a wrapped object.
    //The field’s type should be declared as the component interface
    //so it can contain both concrete components and decorators.
    public abstract class AbsDecorator : AbsComponent
    {
        //wrapee
        protected AbsComponent _component;
        public AbsDecorator(AbsComponent component) => _component = component;
        public override string Operation()
        {
            if (_component is not null) { return _component.Operation(); }
            return string.Empty;
        }
    }
}
