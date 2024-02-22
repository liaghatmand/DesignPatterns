using AbstractFactoryWithDI.EngineFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWithDI.SubFactories.EngineFactories.PetrolEngineFactory
{
    // Concrete Factories for Petrol, Diesel, and Electric Engines
    public class PetrolEngineFactory : IEngineFactory
    {
        public IEngine CreateEngine()
        {
            return new PetrolEngine();
        }
    }
}
