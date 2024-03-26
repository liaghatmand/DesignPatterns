using FactoryStrategyIntegration.ConcreteProduct;
using FactoryStrategyIntegration.Product;

namespace FactoryStrategyIntegration.Creator
{
    public class OrderFactory
    {
        public IOrder CreateOrder(string ordersType)
        {
            switch (ordersType.ToLower())
            {
                case "FoodOrder":
                    return new FoodOrder();

                case "DrinkOrder":
                    return new DrinkOrder();

                default:
                    throw new ArgumentException("Invalid order type", nameof(ordersType));
            }
        }

    }
}
