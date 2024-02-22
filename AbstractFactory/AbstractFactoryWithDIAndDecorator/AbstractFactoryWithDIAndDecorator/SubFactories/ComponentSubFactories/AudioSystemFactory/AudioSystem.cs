using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryWithDI.MainFactory;

namespace AbstractFactoryWithDI.SubFactories.ComponentFactories.AudioSystemFactory
{
    // Concrete Product for AudioSystem
    public class AudioSystem : IVehicleComponent
    {
        public string GetName()
        {
            return "Audio System";
        }
    }
}
