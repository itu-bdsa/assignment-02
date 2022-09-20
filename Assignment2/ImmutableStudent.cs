namespace Assignment2;

public record ImmutableStudent(int Id, string GivenName, string Surname, DateTime StartDate, DateTime EndDate, DateTime GraduationDate)
{
    public Status Status { get=> FindStatus(DateTime.Now); }
    
    private Status FindStatus(DateTime t)
    {
        if (GraduationDate == EndDate && GraduationDate < t) return Status.Graduated;
        else if (EndDate < GraduationDate) return Status.Dropout;
        else if (StartDate > t) return Status.New;
        else return Status.Active;
    }
}