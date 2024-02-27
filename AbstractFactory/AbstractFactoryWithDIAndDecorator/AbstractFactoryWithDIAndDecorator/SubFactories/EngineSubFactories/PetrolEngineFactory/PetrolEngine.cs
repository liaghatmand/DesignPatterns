using AbstractFactoryWithDI.EngineFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWithDI.SubFactories.EngineFactories.PetrolEngineFactory
{
    // Concrete Product for Petrol Engine
    public class PetrolEngine : IEngine
    {
        public string Start()
        {
            return "Petrol Engine started";
        }

        public string GetName()
        {
            return "Petrol Engine";
        }
    }
}
