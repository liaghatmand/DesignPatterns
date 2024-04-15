using BuilderPattern.Builder;
using BuilderPattern.Product;

namespace BuilderPattern.ConcreteBuilder
{
    public class OnlineOrderBuilder : IOrderBuilder
    {

        private  Order _order = new Order ();

        public void AddProduct(string product, int quantity)
        {
            _order.Products.Add(product);
            _order.Quantities.Add(quantity);
        }

        public Order GetOrder()
        {
            return _order;
        }

        public void SetDeliveryAddress(string address)
        {
            _order.DeliveryAddress = address;
        }

        public void SetPaymentStatus(bool isPaid)
        {
            _order.IsPaid = isPaid;
        }
    }
}
