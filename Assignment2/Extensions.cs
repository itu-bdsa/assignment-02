namespace Assignment2;

public static class Extensions
{

    public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> xs) => xs.SelectMany(x => x);

    public static IEnumerable<int> Filter(this IEnumerable<int> items) => items.Where(x => x > 42 && x % 7 == 0);
    public static IEnumerable<int> FilterLeap(this IEnumerable<int> items) => items.Where(year => ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)));

    public static bool isSecure(Uri uri) => uri switch
    {
        { Scheme: "https" } => true,
        _ => false
    };

    public static int WordCount(this String str) => str.Split(new char[] { ' ', '.', '?', '4', '9' }, StringSplitOptions.RemoveEmptyEntries).Length;
}


