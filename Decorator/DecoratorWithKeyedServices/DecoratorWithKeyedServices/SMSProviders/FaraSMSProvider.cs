using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorWithKeyedServices.Interfaces;

namespace DecoratorWithKeyedServices.SMSProviders
{
    public class FaraSMSProvider : ISMSProvider
    {
        public const string ProviderKey = "Fara";
        public void Send()
        {
            Console.WriteLine("Sending sms from FaraProvider");
        }
    }
}
