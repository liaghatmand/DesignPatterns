using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter payment type ( Creditcard/Banktransfer/Paypal ) : ");
            string paymentType = Console.ReadLine();

            Console.Write("Enter amount: ");
            double amount = double.Parse(Console.ReadLine());

            IPayment payment = PaymentFactory.CreatePayment(paymentType);
            payment.ProcessPayment(amount);
        }

    }
}
