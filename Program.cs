using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using NeerCore.DependencyInjection.Extensions;
using NeerCore.Examples.ConsoleDependencyInjection.Services;

var services = new ServiceCollection();
services.AddServicesFromAssembly(Assembly.GetExecutingAssembly());
var serviceProvider = services.BuildServiceProvider();

var commandManager = serviceProvider.GetRequiredService<CommandInvoker>();
int result = commandManager.InvokeAddCommand();
Console.WriteLine("Result = " + result);