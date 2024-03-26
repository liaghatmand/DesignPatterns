using FactoryStrategyIntegration.Product;

namespace FactoryStrategyIntegration.Context
{
    public class OrderProcessor
    {
        private IOrder _order;

        public OrderProcessor(IOrder order)
        {
            _order = order;
        }

        public void SetOrderFactory(IOrder order)
        {
            _order = order;
        }

        public void ProcessOrder()
        {
            _order.Process();
        }

    }
}
