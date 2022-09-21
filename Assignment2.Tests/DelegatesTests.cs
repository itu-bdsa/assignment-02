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
        var s = "Hej med deg";
        Assert.Equal("ged dem jeH", Delegates.stringReverseLambda(s));
    }

    [Fact]
    public void lambda_given_two_deicmals_return_product()
    {
        var a = 5.5;
        var b = 6.6321;

        Assert.Equal(a + b, Delegates.DecimalsProductLambda(a, b));
    }

    [Fact]
    public void lambda_given_0042_and_42_return_true()
    {
        var a = 42;
        var b = "0042";

        Assert.True(Delegates.EqualLambda(a, b));
    }

    [Fact]
    public void lambda_given_420_and_0420_return_true()
    {
        var a = 420;
        var b = "0420";

        Assert.True(Delegates.EqualLambda(a, b));
    }

    [Fact]
    public void lambda_given_66_and_33_return_false()
    {
        var a = 66;
        var b = "33";

        Assert.False(Delegates.EqualLambda(a, b));
    }

}
