using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryWithDI.EngineFactory;
using AbstractFactoryWithDI.MainFactory;

namespace AbstractFactoryWithDI.Client
{
    // Concrete Car as a client
    public class Car : ICar
    {
        private readonly IEngine engine;
        private readonly IVehicleComponent component;

        public Car(IEngineFactory engineFactory, IVehicleComponentFactory componentFactory)
        {
            engine = engineFactory.CreateEngine();
            component = componentFactory.CreateComponent();
        }

        public string Start()
        {
            return $"{engine.Start()} with {component.GetName()}";
        }
    }
}
