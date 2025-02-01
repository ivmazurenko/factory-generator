using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace Factory.Generator;

public static class SourceProductionContextExtensions
{
    static int counter = 0;

    public static void Debug(this SourceProductionContext context, object? code, string? token = null)
    {
        context.AddSource($"{token}{counter++}.txt",
            SourceText.From("/*\n\n" + (code?.ToString() ?? "N-U-L-L") + "\n\n*/", Encoding.UTF8));
    }
}