namespace StudentLibrary;

public class Student
{
    public int Id { get; init; }
    public string GivenName { get; set; }
    public string SurName { get; set; }
    public Status Status { get; private set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime GraduationDate { get; set; }

    public override string ToString()
    {
        return base.ToString()!;
    }
}