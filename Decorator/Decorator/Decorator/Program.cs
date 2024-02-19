using Decorator.Client;
using Decorator.Component;
using Decorator.Decorators;

Client client = new();
var simple = new Component();
client.ClientCode(simple);
Console.WriteLine();

Console.WriteLine("Client: Now I've got a decorated component:");
DecoratorA decoratorA = new DecoratorA(simple);
client.ClientCode(decoratorA);
Console.WriteLine();
DecoratorB decoratorB = new DecoratorB(decoratorA);
client.ClientCode(decoratorB);
Console.WriteLine();