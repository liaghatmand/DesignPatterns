using DecoratorWithKeyedServices.Interfaces;
using DecoratorWithKeyedServices.SMSProviders;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorWithKeyedServices.Client
{
    public class Client : IClient
    {
        private readonly ISMSProvider _faraSMSProvider;
        private readonly ISMSProvider _asaSMSProvider;
        public Client(
        [FromKeyedServices(FaraSMSProvider.ProviderKey)] ISMSProvider faraSMSProvider,
        [FromKeyedServices(AsaSMSProvider.ProviderKey)] ISMSProvider asaSMSProvider)
        {
            _faraSMSProvider = faraSMSProvider;
            _asaSMSProvider = asaSMSProvider;
        }
        public void Send()
        {
            _faraSMSProvider.Send();
            _asaSMSProvider.Send();
        }
    }
}
