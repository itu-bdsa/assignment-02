namespace Assignment2;

public record ImmutableStudent
{
    public int Id { get; init; }
    public string GivenName { get; init; } = string.Empty;
    public string Surname { get; init; } = string.Empty;
    public Status Status { get; init; }
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
    public DateTime GraduationDate { get; init; }

    public ImmutableStudent(int id, string givenname, string surname, DateTime startdate, DateTime enddate, DateTime graduationdate)
    {
        (Id, GivenName, Surname, StartDate, EndDate, GraduationDate) = (id, givenname, surname, startdate, enddate, graduationdate);
        Status = FindStatus(DateTime.Now);
    }
    private Status FindStatus(DateTime t)
    {
        if (GraduationDate == EndDate && GraduationDate < t) return Status.Graduated;
        else if (EndDate < GraduationDate) return Status.Dropout;
        else if (StartDate > t) return Status.New;
        else return Status.Active;
    }
}