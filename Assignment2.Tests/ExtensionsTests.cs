namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void list_array_returns_as_flattened()
    {
        //Arrange
        IEnumerable<int[]> xs = new List<int[]> { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 } };

        //Act
        var expected = new[] { 1, 2, 3, 4, 5, 6 };
        var returned = xs.Flatten();

        //Assert
        Assert.Equal(expected, returned);
    }

    [Fact]
    public void filter_returns_numbers_larger_than_42_and_divisible_by7()
    {
        //Arrange
        IEnumerable<int> xs = new List<int> { 1, 22, 33, 44, 49, 55, 6, 7, 8, 9, 10, 77, 102 };
        //Act
        var expected = new[] { 49, 77 };
        var returned = xs.Filter();

        //Assert
        Assert.Equal(expected, returned);
    }

    [Fact]
    public void Test3()
    {
        //Arrange
        IEnumerable<int> xs = new List<int> { 1653, 1654, 1800, 2000, 2004, 2012 };
        //Act
        var expected = new[] { 2000, 2004, 2012 };
        var returned = xs.FilterLeap();

        //Assert
        Assert.Equal(expected, returned);
    }

    [Fact]
    public void word_count_returns_the_number_of_words_in_the_string()
    {
        string str = "Hej vi er to mennesker, og vi er 49 år gamle. ITU er det fedeste";

        var expected = 14;

        var actual = Extensions.WordCount(str);

        Assert.Equal(expected, actual);

    }

    [Fact]
    public void uri_given_Https_Returns_True()
    {

        Uri link = new Uri("https://itu.dk");

        var expected = true;

        var actual = Extensions.isSecure(link);

        Assert.Equal(expected, actual);

    }
    [Fact]
    public void uri_given_Http_Returns_False()
    {

        Uri link = new Uri("http://itu.dk");

        var expected = false;

        var actual = Extensions.isSecure(link);

        Assert.Equal(expected, actual);
    }
}
