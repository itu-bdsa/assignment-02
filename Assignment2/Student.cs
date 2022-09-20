namespace Assignment2;
public enum Status { New, Active, Dropout, Graduated }

public class Student
{
    public int Id { get; init; }
    public string GivenName { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public Status Status { get => FindStatus(DateTime.Now); }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime GraduationDate { get; set; }

    private Status FindStatus(DateTime t)
    {
        if (GraduationDate == EndDate && GraduationDate < t) return Status.Graduated;
        else if (EndDate < GraduationDate) return Status.Dropout;
        else if (StartDate > t) return Status.New;
        else return Status.Active;
    }

    override public string ToString() 
        => GivenName + " " + Surname + " with ID " + Id + " is " + ((Status == Status.Dropout) ? "a " : string.Empty) + Status.ToString().ToLower();
}