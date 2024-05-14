using BuilderPattern.ConcreteBuilder;
using BuilderPattern.Director;
using BuilderPattern.Product;

namespace BuilderPattern.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            OnlineOrderBuilder builder = new OnlineOrderBuilder();
            OrderProcessor processor = new OrderProcessor(builder);

            processor.ConstructOrder();
            Order onlineOrder = processor.GetOrder();
            onlineOrder.Display();  // Display order details
        }

    }
}
