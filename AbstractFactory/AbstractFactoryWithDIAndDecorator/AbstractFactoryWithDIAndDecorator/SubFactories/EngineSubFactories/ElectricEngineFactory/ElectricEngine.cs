using AbstractFactoryWithDI.EngineFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Concrete Product for Electric Engine
public class ElectricEngine : IEngine
{
    public string Start()
    {
        return "Electric Engine started";
    }

    public string GetName()
    {
        return "Electric Engine";
    }
}

