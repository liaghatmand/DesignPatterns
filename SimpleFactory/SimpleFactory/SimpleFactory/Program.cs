using SimpleFactory;
public class Program
{
    private static void Main(string[] args)
    {
        IVehicle vehicle = SimpleFactory.SimpleFactory.Create("car");

        Console.WriteLine(vehicle.Kind());
    }
}