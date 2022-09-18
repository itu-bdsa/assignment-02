namespace Assignment2;

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
        throw new NotImplementedException();
    }

    public static int WordCount(this string toCount)
    {
        throw new NotImplementedException();
    }
}
