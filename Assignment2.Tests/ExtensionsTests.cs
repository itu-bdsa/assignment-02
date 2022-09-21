namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Test1()
    {
        Uri uri=new Uri("https://www.youtube.com/");
        var test1=Extensions.isSecure(uri);

        test1.Should().BeTrue();

    }

    [Fact]
    public void test2(){
        String s= new String ("Hello World I am very happy :3");
        var test2=Extensions.wordCount(s);

        test2.Should().Be(6);
    }
}

