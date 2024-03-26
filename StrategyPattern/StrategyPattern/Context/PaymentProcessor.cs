using StrategyPattern.IStrategy;

namespace StrategyPattern.Context
{
    public class PaymentProcessor
    {
        private IPaymentGateway _paymentGateway;

        public PaymentProcessor(IPaymentGateway paymentGateway)
        {
            _paymentGateway = paymentGateway;
        }

        public void SetPaymentGateway(IPaymentGateway paymentGateway)
        {
            _paymentGateway = paymentGateway;
        }

        public void ProcessPayment(double amount)
        {
            _paymentGateway.ProcessPayment(amount);
        }

    }
}
