namespace University;
public class Student
{

    public int Id { get; init; }
    public string GivenName { get; set; }
    public string Surname { get; set; }
    public StudentStatus Status { get; }
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; set; }
    public DateTime GraduationDate { get; set; }

    public Student(int Id, string GivenName, string Surname, DateTime StartDate, DateTime EndDate, DateTime GraduationDate)
    {
        this.Id = Id;
        this.GivenName = GivenName;
        this.Surname = Surname;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.GraduationDate = GraduationDate;

    }

    public enum StudentStatus
    {
        New, Active, Dropout, Graduated
    }

}
