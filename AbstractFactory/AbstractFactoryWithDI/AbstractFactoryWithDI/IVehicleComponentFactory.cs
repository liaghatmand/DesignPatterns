using System;

// Abstract Factory for Vehicle Components
public interface IVehicleComponentFactory
{
    IVehicleComponent CreateComponent();
}
