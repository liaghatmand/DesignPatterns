using DecoratorWithKeyedServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorWithKeyedServices.SMSProviders
{
    internal class SMSDecorator : ISMSProvider
    {
        private readonly ISMSProvider _sMSProvider;
        public SMSDecorator(ISMSProvider sMSProvider)
        {
            _sMSProvider = sMSProvider;
        }
        public void Send()
        {
            _sMSProvider.Send();
        }
    }
}
