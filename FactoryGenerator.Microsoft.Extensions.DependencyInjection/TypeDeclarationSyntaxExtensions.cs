using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FactoryGenerator.Microsoft.Extensions.DependencyInjection;

public static class TypeDeclarationSyntaxExtensions
{
    public static bool HasTargetAttribute(this TypeDeclarationSyntax typeDeclarationSyntax)
    {
        return typeDeclarationSyntax.AttributeLists
            .SelectMany(al => al.Attributes)
            .Any(attr => attr.Name.ToString().Contains("GenerateIFactory"));
    }
}