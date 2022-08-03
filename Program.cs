﻿using Microsoft.Extensions.DependencyInjection;
using NeerCore.DependencyInjection.Extensions;
using NeerCore.Examples.ConsoleDependencyInjection.Services;

var services = new ServiceCollection();
// TODO: Use 'AddAllServices' after NeerCore v1.5.0
services.AddServicesFromCurrentAssembly(options =>
{
    options.DefaultLifetime = ServiceLifetime.Transient;
});
var serviceProvider = services.BuildServiceProvider();

var commandManager = serviceProvider.GetRequiredService<CommandInvoker>();
int result = commandManager.InvokeAddCommand();
Console.WriteLine("Result = " + result);