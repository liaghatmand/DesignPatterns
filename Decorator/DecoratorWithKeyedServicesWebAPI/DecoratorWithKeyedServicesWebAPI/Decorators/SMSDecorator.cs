using DecoratorWithKeyedServicesWebAPI.Interfaces;

namespace DecoratorWithKeyedServicesWebAPI.Decorators
{
    public class SMSDecorator : ISMSProvider
    {
        private readonly ISMSProvider _sMSProvider;
        public SMSDecorator(ISMSProvider sMSProvider)
        {
            _sMSProvider = sMSProvider;
        }
        public void Send(string message)
        {
            _sMSProvider.Send(message);
        }
    }
}
