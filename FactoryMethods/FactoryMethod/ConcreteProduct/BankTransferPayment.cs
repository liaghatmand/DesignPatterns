using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
    public class BankTransferPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing bank transfer payment of ${amount}");
        }
    }
}
