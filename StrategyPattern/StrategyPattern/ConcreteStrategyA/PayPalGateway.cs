using StrategyPattern.IStrategy;

namespace StrategyPattern.ConcreteStrategyA
{
    public class PayPalGateway : IPaymentGateway
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of {amount} via PayPal.");
        }
    }
}
