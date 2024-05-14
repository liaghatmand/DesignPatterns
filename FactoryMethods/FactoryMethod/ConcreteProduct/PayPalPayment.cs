using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
    public class PayPalPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount}");
        }
    }
}
