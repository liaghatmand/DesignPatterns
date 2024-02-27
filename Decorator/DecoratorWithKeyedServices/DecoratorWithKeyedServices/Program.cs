using DecoratorWithKeyedServices.Client;
using DecoratorWithKeyedServices.Interfaces;
using DecoratorWithKeyedServices.SMSProviders;
using Microsoft.Extensions.DependencyInjection;
using System;

var services = new ServiceCollection()
    .AddKeyedSingleton<ISMSProvider,AsaSMSProvider >(AsaSMSProvider.ProviderKey)
    .AddKeyedSingleton<ISMSProvider,FaraSMSProvider>(FaraSMSProvider.ProviderKey)
    .AddSingleton<ISMSProvider,SMSDecorator>()
.AddSingleton<SMSDecorator>(services =>
      {
          var asa = services.GetRequiredKeyedService<ISMSProvider>(AsaSMSProvider.ProviderKey);
          var fara = services.GetRequiredKeyedService<ISMSProvider>(FaraSMSProvider.ProviderKey);
          //some conditional logic reading from config to choose fara or asa
              return new SMSDecorator(asa);
      }
    ).BuildServiceProvider(); 

var client = services.GetRequiredService<SMSDecorator>();
client.Send();