using FactoryStrategyIntegration.Product;

namespace FactoryStrategyIntegration.ConcreteProduct
{
    public class DrinkOrder : IOrder
    {
        public void Process()
        {
            Console.WriteLine("Processing drink order...");
        }
    }
}
