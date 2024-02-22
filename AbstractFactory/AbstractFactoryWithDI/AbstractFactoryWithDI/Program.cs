using System;
using AbstractFactoryWithDI.Client;
using AbstractFactoryWithDI.EngineFactory;
using AbstractFactoryWithDI.SubFactories.ComponentFactories.GPSFactory;
using AbstractFactoryWithDI.SubFactories.EngineFactories.PetrolEngineFactory;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main()
    {
        // Create service collection and configure DI
        var serviceProvider = new ServiceCollection()
            .AddScoped<IEngineFactory, PetrolEngineFactory>()
            .AddScoped<IVehicleComponentFactory, GPSFactory>()
            .AddScoped<ICar, Car>()
            .BuildServiceProvider();

        // Resolve instances and use dependency injection
        using (var scope = serviceProvider.CreateScope())
        {
            var sedanCar = scope.ServiceProvider.GetRequiredService<ICar>();
            Console.WriteLine(sedanCar.Start());

            // You can change the factories to create different combinations
            var suvCarStart = scope.ServiceProvider.GetRequiredService<ICar>();
            Console.WriteLine(suvCarStart.Start());
        }
    }
}
