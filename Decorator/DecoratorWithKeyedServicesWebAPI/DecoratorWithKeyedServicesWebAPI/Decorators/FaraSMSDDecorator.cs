using DecoratorWithKeyedServicesWebAPI.Interfaces;

namespace DecoratorWithKeyedServicesWebAPI.Decorators
{
    public class FaraSMSDDecorator : ISMSProvider
    {
        public const string ProviderKey = "Fara";
        public void Send(string message)
        {
            Console.WriteLine("fara");
        }
    }
}
