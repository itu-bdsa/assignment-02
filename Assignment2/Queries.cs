namespace Assignment2;

public class Queries
{
    public static IEnumerable<string> InventedByRowlingExt(WizardCollection wizards)
    {
        return wizards.Where(wizard => wizard.Creator.Contains("Rowling")).Select(wizard => wizard.Name);
    }

    public static IEnumerable<string> InventedByRowlingLINQ(WizardCollection wizards)
    {
        IEnumerable<string> query =
            from wizard in wizards
            where wizard.Creator.Contains("Rowling")
            select wizard.Name;

        return query;
    }

    public static int? FirstSithLordExt(WizardCollection wizards)
    {
        var firstSithLord = wizards.Where(wizard => wizard.Name.StartsWith("Darth")).MinBy(wizard => wizard.Year);
        return firstSithLord == null ? null : firstSithLord.Year;
    }

    public static int? FirstSithLordLINQ(WizardCollection wizards)
    {
        var sithLordYears =
            from wizard in wizards
            where wizard.Name.StartsWith("Darth")
            select wizard.Year;
            
        return sithLordYears.Min();
    }

    public static IEnumerable<(string, int?)> UniqueHarryPotterWizardsExt(WizardCollection wizards)
    {
        return wizards.Where(wizard => wizard.Medium.Contains("Harry Potter")).Select(wizard => (wizard.Name, wizard.Year));
    }

    public static IEnumerable<(string, int?)> UniqueHarryPotterWizardsLINQ(WizardCollection wizards)
    {
        var uniqueWizards =
            from wizard in wizards
            where wizard.Medium.Contains("Harry Potter")
            select (wizard.Name, wizard.Year);
        
        return uniqueWizards;
    }

    public static IEnumerable<string> ListOfWizardsExt(WizardCollection wizards)
    {
        return wizards.OrderByDescending(wizard => wizard.Creator).ThenBy(wizard => wizard.Name).Select(wizard => wizard.Name);
    }

    public static IEnumerable<string> ListOfWizardsLINQ(WizardCollection wizards)
    {
        return 
            from wizard in wizards
            orderby wizard.Creator descending
            orderby wizard.Name
            select wizard.Name;
    }
}
