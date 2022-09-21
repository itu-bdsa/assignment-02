namespace Assignment2.Tests;

public class DelegatesTests
{   
    //These tests were made for Func delegates.
    //How do you unit test for prints to the console?
    /*[Fact]
    public void ReverseOrder_Should_Succeed()
    {
        //Arrange
        var expected = "moT";
        //Act
        var output = Assignment2.Delegates.ReverseOrder("Tom");
        //Assert
        output.Should().BeEquivalentTo(expected);
    }
    [Fact]
    public void ReverseOrder_Should_Fail()
    {
        //Arrange
        var expected = "moT";
        //Act
        var output = Assignment2.Delegates.ReverseOrder("Tomm");
        //Assert
        output.Should().NotBeEquivalentTo(expected);
    }*/
    [Fact]
    public void ProductOfTwoDoubles_Should_Be_6_25()
    {
        //Arrange
        var expected = 6.25;
        //Act
        var output = Assignment2.Delegates.ProductOfTwoDoubles(2.5,2.5);
        //Assert
        output.Should().Be(expected);
    }   

    [Fact]
    public void ProductOfTwoDoubles_Should_Not_Be_6_25()
    {
        //Arrange
        var expected = 6.25;
        //Act
        var output = Assignment2.Delegates.ProductOfTwoDoubles(2.5,10.5);
        //Assert
        output.Should().NotBe(expected);
    }
    [Fact]
    public void NumericallyEqual_Should_Be_True()
    {
        //Arrange
        var expected = true;
        //Act
        var output = Assignment2.Delegates.NumericallyEqual(42, "0042");
        //Assert
        output.Should().Be(expected);
    }

    [Fact]
    public void NumericallyEqual_Should_Be_False()
    {
        //Arrange
        var expected = true;
        //Act
        var output = Assignment2.Delegates.NumericallyEqual(420, "0042");
        //Assert
        output.Should().Be(expected);
    }
}
