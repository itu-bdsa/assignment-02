namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void InventedByExt_given_Rowling_should_return_correct_wizard_names()
    {
        var wizards = WizardCollection.Create();
        string[] expected = { "Harry Potter", "Ron Weasley", "Hermione Granger", "Lord Voldemort" };

        var actual = Queries.InventedByExt(wizards, "Rowling");

        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void InventedByLINQ_given_Rowling_should_return_correct_wizard_names()
    {
        var wizards = WizardCollection.Create();
        string[] expected = { "Harry Potter", "Ron Weasley", "Hermione Granger", "Lord Voldemort" };

        var actual = Queries.InventedByLINQ(wizards, "Rowling");

        actual.Should().BeEquivalentTo(expected);
    }
}
