using System;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace FactoryGenerator.Microsoft.Extensions.DependencyInjection;

[Obsolete]
public static class SourceProductionContextExtensions
{
    private static int counter;

    public static void Debug(this SourceProductionContext context, object? code, string? token = null)
    {
        context.AddSource($"{token}{counter++}.txt",
            SourceText.From("/*\n\n" + (code?.ToString() ?? "N-U-L-L") + "\n\n*/", Encoding.UTF8));
    }
}