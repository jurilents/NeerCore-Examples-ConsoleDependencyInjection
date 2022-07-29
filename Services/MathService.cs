using NeerCore.DependencyInjection;

namespace NeerCore.Examples.ConsoleDependencyInjection.Services;

[Injectable]
public class MathService
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}