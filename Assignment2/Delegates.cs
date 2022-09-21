namespace Assignment2;
using System;
public class Delegates
{

    public static reverse stringReverse = new reverse(x => new String(x.ToCharArray().Reverse().ToArray()));
    public static Func<string, string> stringReverseLambda = (x => new String(x.ToCharArray().Reverse().ToArray()));

    public delegate string reverse(string s);

    public static TwoDecimals DecimalsProduct = (a, b) => a + b;
    public static Func<double, double, double> DecimalsProductLambda = ((a, b) => a + b);
    public delegate double TwoDecimals(double a, double b);

    public static EqualNumbers EqualProduct = ((a, b) => a.ToString() == b.TrimStart('0'));
    public static Func<int, string, bool> EqualLambda = ((a, b) => a.ToString() == b.TrimStart('0'));
    public delegate bool EqualNumbers(int a, string b);
}