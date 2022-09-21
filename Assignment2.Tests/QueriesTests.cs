namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void Get_Names_Where_Creator_Like_Rowling()
    {
        var expected = new[]{"Harry Potter","Voldemort","Albus Dumbledore"};


        var resultExtensions = Queries.GetNamesByCreatorUsingExtensions("Rowling");
        var resultLinq = Queries.GetNamesByCreatorUsingLinq("Rowling");

        resultExtensions.Should().BeEquivalentTo(expected);
        resultLinq.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Get_Sith_lords()
    {
        var resultExtensions = Queries.FindYearsOfSithUsingExtensions();
        var resultLinq = Queries.FindYearsOfSithUsingLinq();

        resultExtensions.Should().BeEquivalentTo(new[]{1977});
        resultLinq.Should().BeEquivalentTo(new[]{1977});

    }
    [Fact]
    public void Year_and_Name_from_Harry_Potter_books()
    {
        var expected = new[]{("Harry Potter",1997),("Albus Dumbledore",1997),("Voldemort",1997)};

        var resultExtensions = Queries.WizardsInHarryPotterUsingExtensions();
        var resultLinq = Queries.WizardsInHarryPotterUsingLinq();

        resultExtensions.Should().BeEquivalentTo(expected);
        resultLinq.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Group_by_reverse_Creator()
    {
        // Given
        var expected = new[]{"Glinda the Good Witch","Stephen Strange","Willow Rosenberg","Jafar","Merlin",
        "Gandalf","Sauron","Albus Dumbledore", "Harry Potter","Voldemort","Darth Vader","Zatanna"};
        // When
        var resultExtensions = Queries.NamesSortedInReverseByCreatorExtensions();
        var resultLinq = Queries.NamesSortedInReverseByCreatorLinq();
        // Then
        Assert.Equal(expected,resultExtensions);
        Assert.Equal(expected,resultLinq);
    }
}
