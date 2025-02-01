using Microsoft.CodeAnalysis;

namespace Factory.Generator;

public readonly record struct Dependency(
    DependencyKind Kind,
    string FullTypeName,
    string TokenName,
    ITypeSymbol RoslynType)
{
    public readonly DependencyKind Kind = Kind;
    public readonly string FullTypeName = FullTypeName;
    public readonly string TokenName = TokenName;
    public readonly ITypeSymbol RoslynType = RoslynType;
}