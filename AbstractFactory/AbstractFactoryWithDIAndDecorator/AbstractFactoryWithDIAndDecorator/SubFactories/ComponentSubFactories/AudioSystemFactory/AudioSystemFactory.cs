using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryWithDI.MainFactory;

namespace AbstractFactoryWithDI.SubFactories.ComponentFactories.AudioSystemFactory
{
    public class AudioSystemFactory : IVehicleComponentFactory
    {
        public IVehicleComponent CreateComponent()
        {
            return new AudioSystem();
        }
    }
}
