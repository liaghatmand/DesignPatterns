using StrategyPattern.ConcreteStrategyA;
using StrategyPattern.ConcreteStrategyB;
using StrategyPattern.Context;

namespace StrategyPattern.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Creating payment processor with PayPal strategy
            var paymentProcessor = new PaymentProcessor(new PayPalGateway());
            paymentProcessor.ProcessPayment(100.50);


            // Changing payment gateway strategy to Stripe
            paymentProcessor.SetPaymentGateway(new StripeGateway());
            paymentProcessor.ProcessPayment(200.75);

        }
    }
}
