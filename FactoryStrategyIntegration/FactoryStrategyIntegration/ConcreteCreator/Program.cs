using FactoryStrategyIntegration.ConcreteProduct;
using FactoryStrategyIntegration.Context;

namespace FactoryStrategyIntegration.ConcreteCreator
{
    public class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor(new FoodOrder());
            orderProcessor.ProcessOrder();

            orderProcessor.SetOrderFactory(new DrinkOrder());
            orderProcessor.ProcessOrder();
        }

    }
}
