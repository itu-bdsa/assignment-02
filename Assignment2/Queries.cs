namespace Assignment2;
using System.Linq;

public class Queries
{
    public static IEnumerable<string> GetNamesByCreatorUsingExtensions(string creatorName){
        var wizCol = WizardCollection.Create();
        return wizCol.Where(w => w.Creator.Contains(creatorName)).Select(w=>w.Name);
    }

    public static IEnumerable<string> GetNamesByCreatorUsingLinq(string creator){
        var wizards = WizardCollection.Create();
        return from w in wizards
         where w.Creator.Contains(creator)
         select w.Name;
    }

    public static IEnumerable<int?> FindYearsOfSithUsingExtensions(){
        var wizards = WizardCollection.Create();
        return wizards.Where(w => w.Name.Contains("Darth")).Select(w=>w.Year);
    }

    public static IEnumerable<int?> FindYearsOfSithUsingLinq(){
        var wizards = WizardCollection.Create();
        return from w in wizards
        where w.Name.Contains("Darth")
        select w.Year;
    }

    public static IEnumerable<(string,int?)> WizardsInHarryPotterUsingExtensions(){
        var wizards = WizardCollection.Create();
        return wizards.Where(w => w.Medium.Contains("Harry Potter")).Select(w=>(w.Name,w.Year));
    }

    public static IEnumerable<(string,int?)> WizardsInHarryPotterUsingLinq(){
        var wizards = WizardCollection.Create();
        return from w in wizards
        where w.Medium.Contains("Harry Potter")
        select (w.Name,w.Year);
    }

    public static IEnumerable<string> NamesSortedInReverseByCreatorExtensions(){
        var wizards = WizardCollection.Create();

        return wizards.GroupBy(w => w.Creator).OrderByDescending(g => g.Key).Select(g => g.OrderBy(w => w.Name)).SelectMany(group=>group).Select(w=>w.Name);

    }

    public static IEnumerable<string> NamesSortedInReverseByCreatorLinq(){
        var wizards = WizardCollection.Create();

        var grouped = from w in wizards
        group w by w.Creator into g
        orderby g.Key descending
        select g.OrderBy(wiz=>wiz.Name);

        return from w in grouped.SelectMany(g=>g)
        select w.Name;

    }

}
