namespace Assignment2;
using System.Text.RegularExpressions;

public static class Extensions
{
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Predicate<T> predicate)
    {
        foreach (var item in items)
        {
            if (predicate(item))
            {
                yield return item;
            }
        }
    }

    public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> items)
    {
        foreach (var item in items)
        {
            foreach (var i in item)
            {
                yield return i;
            }
        }
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
