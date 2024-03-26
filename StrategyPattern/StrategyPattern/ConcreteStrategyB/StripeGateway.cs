using StrategyPattern.IStrategy;

namespace StrategyPattern.ConcreteStrategyB
{
    public class StripeGateway : IPaymentGateway
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of {amount} via Stripe.");
        }
    }
}
