using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    public interface IOrderBuilder
    {
        void AddProduct(string product, int quantity);
        void SetDeliveryAddress(string address);
        void SetPaymentStatus(bool isPaid);
        Order GetOrder();
    }

}
