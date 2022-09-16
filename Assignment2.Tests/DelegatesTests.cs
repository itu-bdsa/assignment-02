namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void isReverseStringTest() // 1.
    {
        ModifyString reverseString = new ModifyString((s) =>
        {
            char[] charArray = s.ToCharArray(); // convert string to char array
            Array.Reverse(charArray); // reverse the char array
            return new string(charArray); // convert char array to string and return
        });

        reverseString("Hello World!").Should().Be("!dlroW olleH");
    }

    [Fact]
    public void isProduct() // 2. 
    {
        DecimalOperation product = new DecimalOperation((a, b) => a * b);

        product(2, 3).Should().Be(6);
    }

    [Fact]
    public void isStringEqualToInt() // 3.
    {
        IntStringCompare stringEqualToInt = new IntStringCompare((i, s) => i == int.Parse(s));

        stringEqualToInt(42, " 0042").Should().BeTrue();
    }
}