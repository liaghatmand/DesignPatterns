using FactoryStrategyIntegration.Product;

namespace FactoryStrategyIntegration.ConcreteProduct
{
    public class FoodOrder : IOrder
    {
        public void Process()
        {
            Console.WriteLine("Processing food order...");
        }
    }
}
