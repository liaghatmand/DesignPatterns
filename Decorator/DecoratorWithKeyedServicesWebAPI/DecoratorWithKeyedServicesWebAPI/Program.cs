using DecoratorWithKeyedServicesWebAPI.Decorators;
using DecoratorWithKeyedServicesWebAPI.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
//the comments are for when you don't use keyedServices:
//builder.Services.AddSingleton<ISMSProvider, FaraSMSDDecorator>();
//builder.Services.AddSingleton<ISMSProvider, AsaSMSDecorator>();
builder.Services.AddKeyedSingleton<ISMSProvider, FaraSMSDDecorator>(FaraSMSDDecorator.ProviderKey);
builder.Services.AddKeyedSingleton<ISMSProvider, AsaSMSDecorator>(AsaSMSDecorator.ProviderKey);
builder.Services.AddSingleton<SMSDecorator>(ServiceProvider =>
{
    //var providers = ServiceProvider.GetServices<ISMSProvider>();
    //var asa = keyedServices.OfType<AsaSMSDecorator>().FirstOrDefault();
    var asa = ServiceProvider.GetRequiredKeyedService<ISMSProvider>
        (AsaSMSDecorator.ProviderKey);
    //some logic to read the prefered wraper from HttpContext
    return new SMSDecorator(asa);
});
builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();