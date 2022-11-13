

using IoC;
using IoC.DependencyInjection;

var services = new DiServiceCollection();

//services.RegisterSingleton<RandomGuidGenerator>();
//services.RegisterTransient<RandomGuidGenerator>();
services.RegisterTransient<ISomeService,SomeServiceOne>();
services.RegisterSingleton<IRandomGuidProvider, RandomGuidProvider>();
//services.RegisterSingleton(new RandomGuidGenerator());


var container = services.GenerateContainer();

var serviceFirst = container.GetService<ISomeService>();
var serviceSecond = container.GetService<ISomeService>();
serviceFirst.PrintSomething();
serviceSecond.PrintSomething();