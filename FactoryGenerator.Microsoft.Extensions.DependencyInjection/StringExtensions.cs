using System.Collections.Generic;

namespace FactoryGenerator.Microsoft.Extensions.DependencyInjection;

public static class StringExtensions
{
    public static string JoinToString(this IEnumerable<string> strings, string separator = ", ")
    {
        return string.Join(separator, strings);
    }
}