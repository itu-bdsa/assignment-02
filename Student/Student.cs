namespace Student;

public class Student
{
    public int Id { get; init; }
    public string GivenName { get; set; }
    public Status Status
    {
        get
        {
            if (StartDate > DateTime.Now) return New;
            else if (StartDate < DateTime.Now && DateTime.Now < GraduationDate && EndDate == null) return Active;
            else if (EndDate != GraduationDate) return Dropout;
            else if (GraduationDate == EndDate) return Graduated;
            else { throw new Exception(); }
        }
    }
    public string Surname { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime GraduationDate { get; set; }

    public Student(int id, string givenName, string surname, DateTime startDate, DateTime? endDate, DateTime graduationDate)
    {
        Id = id;
        GivenName = givenName;
        Surname = surname;
        StartDate = startDate;
        EndDate = endDate;
        GraduationDate = graduationDate;
    }

    public override string ToString()
    {
        return $"[{Id}] {GivenName} {Surname} | {Status}";
    }
}
