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

        var currentDate = DateTime.Now;

        if (EndDate < GraduationDate)
            this.Status = StudentStatus.Dropout;
        else if (GraduationDate < currentDate)
            this.Status = StudentStatus.Graduated;
        else if (StartDate >= currentDate)
            this.Status = StudentStatus.New;
        else
            this.Status = StudentStatus.Active;
    }

    public enum StudentStatus
    {
        New, Active, Dropout, Graduated
    }

    public override string ToString()
    {
        return $"{Id} {GivenName} {Surname} - Status: {Status} Started: {StartDate.ToShortDateString()} End: {EndDate.ToShortDateString()} Graduation: {GraduationDate.ToShortDateString()}";
    }
}





