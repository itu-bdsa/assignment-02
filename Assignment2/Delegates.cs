namespace Assignment2;
using System;
public class Delegates
{
    public delegate void anonymousReverse(string str);
    // Main method
    // An anonymous method with one parameter
    anonymousReverse ar = delegate (string str)
    {
        Console.WriteLine(new String(str.ToCharArray().Reverse().ToArray()));
    };
}