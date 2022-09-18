namespace Assignment2;

public class Queries
{
    public static IEnumerable<string> InventedByExt(WizardCollection wizards, string name)
    {
        return wizards.Where(wizard => wizard.Creator.Contains(name)).Select(wizard => wizard.Name);
    }

    public static IEnumerable<string> InventedByLINQ(WizardCollection wizards, string name)
    {
        IEnumerable<string> query =
            from wizard in wizards
            where wizard.Creator.Contains(name)
            select wizard.Name;

        return query;
    }

    public static int FirstSithLord(WizardCollection wizards)
    {
        // var firstSithLord = wizards.Where(wizard => wizard.Name.StartsWith("Darth")).MinBy(wizard => wizard.Year);
        throw new NotImplementedException();
    }
}
