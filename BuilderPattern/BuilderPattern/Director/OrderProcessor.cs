using BuilderPattern.Builder;
using BuilderPattern.Product;

namespace BuilderPattern.Director
{
    public class OrderProcessor
    {
        private IOrderBuilder _builder;

        public OrderProcessor(IOrderBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructOrder()
        {
            _builder.AddProduct("Laptop", 1);
            _builder.AddProduct("Phone", 2);
            _builder.SetDeliveryAddress("123 Main St");
            _builder.SetPaymentStatus(true);
        }

        public Order GetOrder()
        {
            return _builder.GetOrder();
        }

    }
}
