using AbstractFactoryWithDI.EngineFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWithDI.SubFactories.EngineFactories.DieselEngineFactory
{
    public class DieselEngineFactory : IEngineFactory
    {
        public IEngine CreateEngine()
        {
            return new DieselEngine();
        }
    }
}
