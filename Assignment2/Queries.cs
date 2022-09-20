using Microsoft.VisualBasic;

namespace Assignment2;

public class Queries
{
    public static IEnumerable<string> RowlingWizardsLinq(IEnumerable<Wizard> wizards) => wizards.Where(a => a.Creator == "J.K. Rowling").Select(a => a.Name);
    public static IEnumerable<string> RowlingWizards(IEnumerable<Wizard> wizards) => wizards.Where(a => a.Creator == "J.K. Rowling").Select(a => a.Name);


    public static int? TheYearOfTheFifthSithLordLinq(IEnumerable<Wizard> wizards) => wizards.Where(a => a.Name.Contains("Darth")).Select(a => a.Year).First();
    public static int? TheYearOfTheFifthSithLord(IEnumerable<Wizard> wizards) => wizards.Where(a => a.Name.Contains("Darth")).Select(a => a.Year).First();


    public static IEnumerable<(string, int?)> HarryWizardsLinq(IEnumerable<Wizard> wizards) => wizards.Where(a => a.Medium.Contains("Harry Potter")).Select(a => (a.Name, a.Year));
    public static IEnumerable<(string, int?)> HarryWizards(IEnumerable<Wizard> wizards) => wizards.Where(a => a.Medium.Contains("Harry Potter")).Select(a => (a.Name, a.Year));

    public static IEnumerable<Wizard> WizardsGroupLinq(IEnumerable<Wizard> wizards) => null; //wizards.OrderByDescending(a => a.Creator).ThenBy(a => a.Name).GroupBy(a => a.Creator).Select(a => a);

}
