namespace Assignment2;

public static class Delegates {
    public delegate void ReverseString(string arg);

    public static void PrintReverse(string arg) {
        var reverse = new ReverseString(
            delegate (string arg)
            {
                var stringAsCharArray = arg.ToCharArray();
                for (int i = stringAsCharArray.Length - 1; i >= 0; i--) {
                    Console.Write(stringAsCharArray[i]);
                }
                Console.WriteLine();
            }
        );

        reverse.Invoke(arg);
    }
}