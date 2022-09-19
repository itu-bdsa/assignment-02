namespace Assignment2;

public class Queries
{
    private static WizardCollection wizards = WizardCollection.Create();


    public static IEnumerable<string>? GetRowlingWizardNamesWithLinq()
    {
        return from w in wizards
               where w.Creator.Contains("Rowling")
               select w.Name;
    }

    public static IEnumerable<string>? GetRowlingWizardNamesWithExtensions()
    {
        return wizards.Where(w => w.Creator.Contains("Rowling"))
            .Select(w => w.Name);
    }


    public static int? GetFirstSithLordYearWithLinq()
    {
        var query = from w in wizards
                    where w.Name.StartsWith("Darth")
                    select w.Year;
        return query.Min();
    }

    public static int? GetFirstSithLordYearWithExtensions()
    {
        var query = wizards.Where(w => w.Name.StartsWith("Darth"))
            .Select(w => w.Year);
        return query.Min();
    }


    public static IEnumerable<(string, int?)>? GetHarryPotterWizardsWithLinq()
    {
        return from w in wizards
               where w.Medium.StartsWith("Harry Potter")
               select (w.Name, w.Year);
    }

    public static IEnumerable<(string, int?)>? GetHarryPotterWizardsWithExtensions()
    {
        return wizards.Where(w => w.Medium.StartsWith("Harry Potter"))
            .Select(w => (w.Name, w.Year));
    }

    // Specific order : Grouped by creator in reverse order by creator name and then wizard name
    public static IEnumerable<string>? GetCreatorGroupedWizardNamesWithLinq()
    {
        return from cw in
                (from w in wizards
                 orderby w.Name
                 group w by w.Creator into g
                 orderby g.Key descending
                 select g)
               from w in cw
               select w.Name;
    }

    public static IEnumerable<string>? GetCreatorGroupedWizardNamesWithExtensions()
    {
        return wizards.OrderBy(w => w.Name)
            .GroupBy(w => w.Creator)
            .OrderByDescending(g => g.Key)
            .SelectMany(g => g)
            .Select(w => w.Name);
    }
}
