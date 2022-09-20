namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Flatten_when_calling_on_stream_of_streams_should_return_stream()
    {
        IEnumerable<int>[] xs = new IEnumerable<int>[3];
        xs[0] = new List<int> { 1, 2, 3 };
        xs[1] = new List<int> { 4, 5, 6 };
        xs[2] = new List<int> { 7, 8, 9 };

        var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var actual = xs.Flatten();

        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Filter_should_filter_correctly()
    {
        int[] ys = { 21, 30, 42, 49, 70, 77, 80, 100 };

        int[] expected = { 49, 70, 77 };

        var actual = ys.Filter(y => y > 42 && y % 7 == 0);

        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Filter_should_find_leap_years()
    {
        int[] ys = { 0, 1400, 1600, 1700, 1800, 2000, 2004, 2005 };

        int[] expected = { 1600, 2000, 2004 };

        var actual = ys.Filter(y => y > 1582 && y % 4 == 0 && (y % 100 != 0 || y % 400 == 0));

        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void IsSecure_given_stack_overflow_returns_true()
    {
        Uri uri = new Uri("https://stackoverflow.com");

        bool actual = uri.IsSecure();

        actual.Should().Be(true);
    }

    [Fact]
    public void IsSecure_given_insecure_site_returns_false()
    {
        var uri = new Uri("http://enusikkerside.dk");

        var actual = uri.IsSecure();

        actual.Should().Be(false);
    }

    [Fact]
    public void WordCount_given_lipsum_should_return_19()
    {
        var lipsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
        var expected = 19;

        var actual = lipsum.WordCount();

        actual.Should().Be(expected);
    }

    [Fact]
    public void WordCount_should_ignore_non_letters()
    {
        var line = "There are 6 words in this sentence !!!";
        var expected = 6;

        var actual = line.WordCount();

        actual.Should().Be(expected);
    }
}
