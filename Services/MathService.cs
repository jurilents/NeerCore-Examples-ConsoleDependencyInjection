using NeerCore.DependencyInjection;

namespace NeerCore.Examples.ConsoleDependencyInjection.Services;

[Inject]
public class MathService
{
	public int Add(int a, int b)
	{
		return a + b;
	}
}