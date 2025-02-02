using System.Linq;

namespace FactoryGenerator.Microsoft.Extensions.DependencyInjection;

internal class Model
{
    public Model(Dependency[] dependencies,
        string className,
        string namespaceName)
    {
        Dependencies = dependencies;
        ClassName = className;
        NamespaceName = namespaceName;

        var methodParameterDependencies = dependencies
            .Where(m => m.Kind == DependencyKind.MethodParameter).ToList();

        FactoryTypeName =
            $"{methodParameterDependencies.Select(d => d.RoslynType.Name).JoinToString("")}{className}Factory";

        var iFactoryGenericArguments = methodParameterDependencies
            .Select(d => d.FullTypeName)
            .Append($"{NamespaceName}.{ClassName}")
            .JoinToString();

        FullInterfaceTypeName = $"FactoryGenerator.Abstractions.IFactory<{iFactoryGenericArguments}>";
    }

    public string FullInterfaceTypeName { get; set; }

    public Dependency[] Dependencies { get; }
    public string ClassName { get; }
    public string NamespaceName { get; }
    public string FactoryTypeName { get; }
}