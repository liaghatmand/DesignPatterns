using AbstractFactoryWithDI.MainFactory;

namespace AbstractFactoryWithDI.SubFactories.ComponentFactories.GPSFactory
{
    // Concrete Factories for GPS and AudioSystem
    public class GPSFactory : IVehicleComponentFactory
    {
        public IVehicleComponent CreateComponent()
        {
            return new GPS();
        }
    }
}