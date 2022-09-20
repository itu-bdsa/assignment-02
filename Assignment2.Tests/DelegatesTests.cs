namespace Assignment2.Tests;

public class DelegatesTests
{
    Action<string> reverse = (string toReverse) =>
    {
        foreach (var c in toReverse.Reverse())
        {
            Console.Write(c);
        }
    };

    Func<int, int, int> product = (int a, int b) => a * b;

    Func<int, string, bool> numericallyEqual = (int num, string str) => num.Equals(int.Parse(str));

    [Fact]
    public void Reverse_should_print_string_in_reverse()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);
        var expected = "gid dem jeH";

        // Act
        reverse("Hej med dig");

        var actual = writer.ToString();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void Product_given_two_ints_should_return_product()
    {
        int a = 5, b = 7;
        int expected = 35;

        int actual = product(a, b);

        actual.Should().Be(expected);
    }

    [Fact]
    public void NumericallyEqual_given_equal_number_and_string_should_return_true()
    {
        int num = 42;
        string str = "     0042  ";

        numericallyEqual(num, str).Should().Be(true);
    }


}
