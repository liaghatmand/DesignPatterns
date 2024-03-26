using FactoryMethod.ConcreteProduct;
using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public static class PaymentFactory
    {
        public static IPayment CreatePayment(string paymentType)
        {
            switch (paymentType.ToLower())
            {
                case "creditcard":
                    return new CreditCardPayment();

                case "banktransfer":
                    return new BankTransferPayment();

                case "paypal":
                    return new PayPalPayment();

                default:
                    throw new ArgumentException("Invalid payment type", nameof(paymentType));
            }
        }

    }
}
