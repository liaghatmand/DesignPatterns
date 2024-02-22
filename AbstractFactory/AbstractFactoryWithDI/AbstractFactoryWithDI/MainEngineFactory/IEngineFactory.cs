using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWithDI.EngineFactory
{
    // Abstract Factory for Engines
    public interface IEngineFactory
    {
        IEngine CreateEngine();
    }
}
