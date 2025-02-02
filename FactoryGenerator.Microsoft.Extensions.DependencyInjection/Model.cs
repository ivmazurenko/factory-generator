namespace FactoryGenerator.Microsoft.Extensions.DependencyInjection;

internal class Model(
    Dependency[] dependencies,
    string className,
    string namespaceName)
{
    public Dependency[] Dependencies { get; } = dependencies;
    public string ClassName { get; } = className;
    public string NamespaceName { get; } = namespaceName;
}