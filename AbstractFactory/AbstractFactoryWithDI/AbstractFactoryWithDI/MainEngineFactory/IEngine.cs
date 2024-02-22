using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryWithDI.MainFactory;

namespace AbstractFactoryWithDI.EngineFactory
{
    // Interface for Engine
    public interface IEngine
    {
        string Start();
    }
}
