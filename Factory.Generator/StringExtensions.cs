using System.Collections.Generic;

namespace Factory.Generator;

public static class StringExtensions
{
    public static string JoinToString(this IEnumerable<string> strings, string separator = ", ")
    {
        return string.Join(separator, strings);
    }
}