using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorWithKeyedServices.Interfaces;

namespace DecoratorWithKeyedServices.SMSProviders
{
    public class AsaSMSProvider : ISMSProvider
    {
        public const string ProviderKey = "Asa";
        public void Send()
        {
            Console.WriteLine("Sending sms from AsaProvider");
        }
    }
}