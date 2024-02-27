using DecoratorWithKeyedServicesWebAPI.Interfaces;

namespace DecoratorWithKeyedServicesWebAPI.Decorators
{
    public class AsaSMSDecorator : ISMSProvider
    {
        public const string ProviderKey = "Asa";
        public void Send(string message)
        {
            Console.WriteLine("asa");
        }
    }
}
