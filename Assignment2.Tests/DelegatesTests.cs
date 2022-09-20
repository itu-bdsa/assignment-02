namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void given_string_sentence_returns_reverse()
    {
        var s = "Hej";

        Assert.Equal("jeH", Delegates.stringReverse(s));

    }

    [Fact]
    public void lambda_given_string_sentence_returns_reverse()
    {
        var s = "Hej";
        Assert.Equal("jeH", Delegates.stringReverseLambda(s));
    }
}
