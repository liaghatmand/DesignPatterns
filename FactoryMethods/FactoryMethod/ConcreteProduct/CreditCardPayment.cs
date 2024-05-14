using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
    public class CreditCardPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment of ${amount}");
        }
    }
}
