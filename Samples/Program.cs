using FactoryGenerator.Abstractions;
using FactoryGenerator.Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Samples;

public static class Program
{
    public static void Main()
    {
        var serviceCollection = new ServiceCollection()
            .AddTransient<Dependency>()
            .RegisterGeneratedFactories();

        using var serviceProvider = serviceCollection.BuildServiceProvider();

        var factory = serviceProvider
            .GetRequiredService<IFactory<int, Service>>();

        var service = factory.Create(1);

        service.Run();
    }
}

[GenerateIFactory<int>]
public class Service(int value, Dependency dependency2)
{
    public void Run()
    {
        dependency2.Run(value);
    }
}

public class Dependency
{
    public void Run(int value)
    {
        Console.WriteLine(
            $"Value '{value}' was provided through the factory Create method, while the dependency was resolved from DI");
    }
}