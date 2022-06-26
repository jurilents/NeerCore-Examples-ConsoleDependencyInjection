using Microsoft.Extensions.DependencyInjection;
using NeerCore.DependencyInjection;

namespace NeerCore.Examples.ConsoleDependencyInjection.Services;

[Inject(Lifetime = ServiceLifetime.Singleton)]
public class CommandInvoker
{
	private readonly MathService _mathService;
	public CommandInvoker(MathService mathService) => _mathService = mathService;


	public int InvokeAddCommand()
	{
		Console.Write("a = ");
		int a = int.Parse(Console.ReadLine()!);
		Console.Write("b = ");
		int b = int.Parse(Console.ReadLine()!);
		return _mathService.Add(a, b);
	}
}