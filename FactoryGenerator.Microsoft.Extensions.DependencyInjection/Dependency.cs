using Microsoft.CodeAnalysis;

namespace FactoryGenerator.Microsoft.Extensions.DependencyInjection;

public readonly record struct Dependency(
    DependencyKind Kind,
    string FullTypeName,
    string TokenName,
    ITypeSymbol RoslynType)
{
    public readonly string FullTypeName = FullTypeName;
    public readonly DependencyKind Kind = Kind;
    public readonly ITypeSymbol RoslynType = RoslynType;
    public readonly string TokenName = TokenName;
}