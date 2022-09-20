namespace Assignment2.Tests;

public class QueriesTests
{

    [Fact]
    public void IsRownlingWizards()
    {
        // Arrange
        var actualRowlingWizards = new[] {
            "Voldemort",
            "Grindelwald",
            "Draco Malfoy"
        };

        // Act
        var linqResult = Queries.GetRowlingWizardNamesWithLinq();
        var extensionResult = Queries.GetRowlingWizardNamesWithExtensions();

        // Assert
        linqResult.Should().BeEquivalentTo(actualRowlingWizards);

        extensionResult.Should().BeEquivalentTo(actualRowlingWizards);
    }

    [Fact]
    public void isFirstSithLordYear()
    {
        // Arrange
        var actualFirstSithLordYear = 1977;

        // Act
        var linqResult = Queries.GetFirstSithLordYearWithLinq();
        var extensionResult = Queries.GetFirstSithLordYearWithExtensions();

        // Assert
        linqResult.Should().Be(actualFirstSithLordYear);
        extensionResult.Should().Be(actualFirstSithLordYear);
    }

    [Fact]
    public void isHarryPotterWizards()
    {
        // Arrange
        var actualHarryPotterWizards = new[] {
            ( "Voldemort", 1997 ),
            ( "Draco Malfoy", 1997 )
        };

        // Act
        var linqResult = Queries.GetHarryPotterWizardsWithLinq();
        var extensionResult = Queries.GetHarryPotterWizardsWithExtensions();

        // Assert
        linqResult.Should().BeEquivalentTo(actualHarryPotterWizards);

        extensionResult.Should().BeEquivalentTo(actualHarryPotterWizards);
    }

    [Fact]
    public void isListOfWizardNamesInSpecificOrder()
    {
        // Specific order : Grouped by creator in reverse order by creator name and then wizard name

        // Arrange
        var correctListOrdered = new[] {
            "Morgana",
            "Doctor Strange",
            "Wicked Witch of the West",
            "Harry Dresden",
            "Gandalf",
            "Sauron",
            "Draco Malfoy",
            "Grindelwald",
            "Voldemort",
            "Darth Vader",
            "Maleficent",
            "White Witch"
        };

        // Act
        var linqResult = Queries.GetCreatorGroupedWizardNamesWithLinq();
        var extensionResult = Queries.GetCreatorGroupedWizardNamesWithExtensions();

        // Assert
        linqResult.Should().ContainInOrder(correctListOrdered);
        extensionResult.Should().ContainInOrder(correctListOrdered);
    }
}
