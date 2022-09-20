namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Flatten_ListWithList_1_2_3_4_5__1_2_3_4()
    {
        var list = new List<List<int>>()
        {
            new List<int>() { 1, 2, 3, 4, 5 },
            new List<int>() { 1, 2, 3, 4 }
        };
        var expected = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4 };
        var actual = list.Flatten();
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Flatten_ListWithList_1_2_3_4_5__1_2_3_4_5()
    {
        var list = new List<List<int>>()
        {
            new List<int>() { 1, 2, 3, 4, 5 },
            new List<int>() { 1, 2, 3, 4, 5 }
        };
        var expected = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
        var actual = Extensions.Flatten(list);
        actual.Should().BeEquivalentTo(expected);
    }

    // }
}
