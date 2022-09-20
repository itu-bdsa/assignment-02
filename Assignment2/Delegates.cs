namespace Assignment2;
using System;
public class Delegates
{

    public static reverse stringReverse = new reverse(x => new String(x.ToCharArray().Reverse().ToArray()));
    public static Func<string,string> stringReverseLambda = (x => new String(x.ToCharArray().Reverse().ToArray()));

    public delegate string reverse(string s);
}