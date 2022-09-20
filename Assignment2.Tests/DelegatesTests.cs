namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void isReverseStringTest() // 1.
    {
        // Arrange
        ModifyString reverseString = new ModifyString((s) =>
        {
            char[] charArray = s.ToCharArray(); // convert string to char array
            Array.Reverse(charArray); // reverse the char array
            return new string(charArray); // convert char array to string and return
        });

        // Act
        string reversedString = reverseString("Hello World!");

        // Assert
        reversedString.Should().Be("!dlroW olleH");
    }

    [Fact]
    public void isProduct() // 2. 
    {
        // Arrange
        DecimalOperation product = new DecimalOperation((a, b) => a * b);

        // Act
        decimal productOfTwoThree = product(2, 3);

        // Assert
        productOfTwoThree.Should().Be(6);
    }

    [Fact]
    public void isStringEqualToInt() // 3.
    {
        // Arrange
        IntStringCompare stringEqualToInt = new IntStringCompare((i, s) => i == int.Parse(s));

        // Act
        bool string42EqualToInt = stringEqualToInt(42, " 0042");

        // Arrange
        string42EqualToInt.Should().BeTrue();
    }
}