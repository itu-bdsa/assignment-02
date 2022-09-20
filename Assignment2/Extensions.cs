namespace Assignment2;

public static class Extensions
{
    public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> source) => source.SelectMany(x => x).ToList();
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> filter) => source.Where(filter);
}
