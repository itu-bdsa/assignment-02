namespace Assignment2;
using System.Text.RegularExpressions;

public static class Extensions
{
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Predicate<T> predicate)
    {
        return items.Where(item => predicate(item));
    }

    public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> items)
    {
        return items.SelectMany(i => i);
    }

    public static bool IsSecure(this Uri uri)
    {
        return uri.Scheme.Equals("https");
    }

    public static int WordCount(this string toCount)
    {
        string pattern = @"[A-Za-z]+";
        MatchCollection matches = Regex.Matches(input: toCount, pattern: pattern);
        return matches.Count;
    }
}
