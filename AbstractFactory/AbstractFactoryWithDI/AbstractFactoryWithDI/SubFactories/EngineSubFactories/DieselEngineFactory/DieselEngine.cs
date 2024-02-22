using AbstractFactoryWithDI.EngineFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWithDI.SubFactories.EngineFactories.DieselEngineFactory
{
    // Concrete Product for Diesel Engine
    public class DieselEngine : IEngine
    {
        public string Start()
        {
            return "Diesel Engine started";
        }

        public string GetName()
        {
            return "Diesel Engine";
        }
    }
}
