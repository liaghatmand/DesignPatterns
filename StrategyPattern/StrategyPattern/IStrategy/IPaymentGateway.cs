namespace StrategyPattern.IStrategy
{
    public interface IPaymentGateway
    {
        void ProcessPayment(double amount);
    }
}
