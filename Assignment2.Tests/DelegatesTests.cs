namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void Reverse_String_Delegate_Monkey_Gives_yeknoM()
    {
        // Given
        using var writer = new StringWriter();
        Console.SetOut(writer);
        string monkey = "Monkey";
    
        // When
        Delegates.PrintReverse(monkey);
        var output = writer.GetStringBuilder().ToString().TrimEnd();

        // Then
        output.Should().Be("yeknoM");
    }

    [Fact]
    public void Reverse_String_Delegate_Andreas_Guldborg_Er_Sej_Gives_jeS_rE_grobdluG_saerdnA()
    {
        // Given
        using var writer = new StringWriter();
        Console.SetOut(writer);
        string input = "Andreas Guldborg Er Sej";
    
        // When
        Delegates.PrintReverse(input);
        var output = writer.GetStringBuilder().ToString().TrimEnd();
    
        // Then
        output.Should().Be("jeS rE grobdluG saerdnA");
    }

    [Fact]
    public void Reverse_String_Delegate_123_456_78_Gives_87_654_321()
    {
        // Given
        using var writer = new StringWriter();
        Console.SetOut(writer);
        string input = "123 456 78";
    
        // When
        Delegates.PrintReverse(input);
        var output = writer.GetStringBuilder().ToString().TrimEnd();
    
        // Then
        output.Should().Be("87 654 321");
    }
}
