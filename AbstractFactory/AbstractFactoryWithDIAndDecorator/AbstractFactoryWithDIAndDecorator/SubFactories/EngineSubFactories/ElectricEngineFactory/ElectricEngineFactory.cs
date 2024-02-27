using AbstractFactoryWithDI.EngineFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWithDI.SubFactories.EngineFactories.ElectricEngineFactory
{
    public class ElectricEngineFactory : IEngineFactory
    {
        public IEngine CreateEngine()
        {
            return new ElectricEngine();
        }
    }
}
