using AbstractFactoryWithDI.MainFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Concrete Product for GPS
public class GPS : IVehicleComponent
{
    public string GetName()
    {
        return "GPS";
    }
}
