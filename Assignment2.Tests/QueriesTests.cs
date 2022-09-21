namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void InventedByExt_given_Rowling_should_return_correct_wizard_names()
    {
        // Arrange
        var wizards = WizardCollection.Create();
        string[] expected = { "Harry Potter", "Ron Weasley", "Hermione Granger", "Lord Voldemort" };

        // Act
        var actual = Queries.InventedByRowlingExt(wizards);

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void InventedByLINQ_given_Rowling_should_return_correct_wizard_names()
    {
        // Arrange
        var wizards = WizardCollection.Create();
        string[] expected = { "Harry Potter", "Ron Weasley", "Hermione Granger", "Lord Voldemort" };

        // Act
        var actual = Queries.InventedByRowlingLINQ(wizards);

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void FirstSithLordExt_should_return_1977()
    {
        // Arrange
        var wizards = WizardCollection.Create();
        int expected = 1977;

        // Act
        int? actual = Queries.FirstSithLordExt(wizards);
        
        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void FirstSithLordLINQ_should_return_1977()
    {
        // Arrange
        var wizards = WizardCollection.Create();
        int expected = 1977;

        // Act
        int? actual = Queries.FirstSithLordLINQ(wizards);
        
        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void UniqueHarryPotterWizardsExt()
    {
        // Arrange
        var wizards = WizardCollection.Create();
        var expected = new List<(string, int)>{
            ("Harry Potter", 1997),
            ("Ron Weasley", 1997),
            ("Hermione Granger", 1997),
            ("Lord Voldemort", 1997)};
        
        // Act
        var actual = Queries.UniqueHarryPotterWizardsExt(wizards);

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void UniqueHarryPotterWizardsLINQ()
    {
        // Arrange
        var wizards = WizardCollection.Create();
        var expected = new List<(string, int)>{
            ("Harry Potter", 1997),
            ("Ron Weasley", 1997),
            ("Hermione Granger", 1997),
            ("Lord Voldemort", 1997)};
        
        // Act
        var actual = Queries.UniqueHarryPotterWizardsLINQ(wizards);

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void ListOfWizardsExt()
    {
        // Arrange
        var wizards = WizardCollection.Create();
        string[] expected = {
            "Merlin",
            "Dr. Strange",
            "Gandalf the Grey",
            "Gandalf the White",
            "Sauron",
            "Harry Potter",
            "Hermione Granger",
            "Lord Voldemort",
            "Ron Weasley",
            "Darth Maul",
            "Darth Vader",
            "Obi-Wan Kenobi"};
        /**
        "Merlin","The Sword in the Stone",1938,"T.H. White"
        
        "Dr. Strange","Doctor Strange",2016,"Stan Lee"

        "Gandalf the Grey","The Fellowship of the Ring",1954,"J.R.R. Tolkien"
        "Gandalf the White","The Return of the King",1955,"J.R.R. Tolkien"
        "Sauron","The Fellowship of the Ring",1954,"J.R.R. Tolkien"

        "Harry Potter","Harry Potter and the Sorcerer's Stone",1997,"J.K. Rowling"
        "Hermione Granger","Harry Potter and the Sorcerer's Stone",1997,"J.K. Rowling"
        "Lord Voldemort","Harry Potter and the Sorcerer's Stone",1997,"J.K. Rowling"
        "Ron Weasley","Harry Potter and the Sorcerer's Stone",1997,"J.K. Rowling"

        "Darth Maul","Star Wars: Episode I - The Phantom Menace",1999,"George Lucas"
        "Darth Vader","Star Wars: Episode IV - A New Hope",1977,"George Lucas"
        "Obi-Wan Kenobi","Star Wars: Episode IV - A New Hope",1977,"George Lucas"
        */

        // Act
        var actual = Queries.ListOfWizardsExt(wizards);

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void ListOfWizardsLINQ()
    {
        // Arrange
        var wizards = WizardCollection.Create();
        string[] expected = {
            "Merlin",
            "Dr. Strange",
            "Gandalf the Grey",
            "Gandalf the White",
            "Sauron",
            "Harry Potter",
            "Hermione Granger",
            "Lord Voldemort",
            "Ron Weasley",
            "Darth Maul",
            "Darth Vader",
            "Obi-Wan Kenobi"};
        /**
        "Merlin","The Sword in the Stone",1938,"T.H. White"
        
        "Dr. Strange","Doctor Strange",2016,"Stan Lee"

        "Gandalf the Grey","The Fellowship of the Ring",1954,"J.R.R. Tolkien"
        "Gandalf the White","The Return of the King",1955,"J.R.R. Tolkien"
        "Sauron","The Fellowship of the Ring",1954,"J.R.R. Tolkien"

        "Harry Potter","Harry Potter and the Sorcerer's Stone",1997,"J.K. Rowling"
        "Hermione Granger","Harry Potter and the Sorcerer's Stone",1997,"J.K. Rowling"
        "Lord Voldemort","Harry Potter and the Sorcerer's Stone",1997,"J.K. Rowling"
        "Ron Weasley","Harry Potter and the Sorcerer's Stone",1997,"J.K. Rowling"

        "Darth Maul","Star Wars: Episode I - The Phantom Menace",1999,"George Lucas"
        "Darth Vader","Star Wars: Episode IV - A New Hope",1977,"George Lucas"
        "Obi-Wan Kenobi","Star Wars: Episode IV - A New Hope",1977,"George Lucas"
        */

        // Act
        var actual = Queries.ListOfWizardsLINQ(wizards);

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }
}
