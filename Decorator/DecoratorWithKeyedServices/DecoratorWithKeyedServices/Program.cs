using DecoratorWithKeyedServices.Client;
using DecoratorWithKeyedServices.Interfaces;
using DecoratorWithKeyedServices.SMSProviders;
using Microsoft.Extensions.DependencyInjection;
using System;

var services = new ServiceCollection()
    .AddKeyedSingleton<ISMSProvider,AsaSMSProvider >(AsaSMSProvider.ProviderKey)
    .AddKeyedSingleton<ISMSProvider,FaraSMSProvider>(FaraSMSProvider.ProviderKey)
    .AddScoped<IClient, Client>()
    .BuildServiceProvider() ;
    
var client = services.GetRequiredService<IClient>();
client.Send();

