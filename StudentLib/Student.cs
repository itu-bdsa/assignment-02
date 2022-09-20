namespace Assignment2.StudentLib;

public class Student
{
    public int Id { get; init; }
    public string? GivenName { get; set; }
    public string? Surname { get; set; }
    public Status Status { get; set; }
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; set; }
    public DateTime GraduationDate { get; set; }

    public Student(string Givenname, string Surname)
    {
        Random rnd = new Random();
        this.Id = rnd.Next();
        this.GivenName = Givenname;
        this.Surname = Surname;
        this.StartDate = DateTime.Now;
        this.GraduationDate = StartDate.AddYears(3); //ignoring 3 month gap
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {GivenName} {Surname}, Status: {Status}, StartDate: {StartDate}, GraduationDate: {GraduationDate}";
    }

    public Status getStatus()
    {
        var now = DateTime.Now;
        var stNew = DateTime.Compare(now, StartDate.AddDays(5)); //-1, 0, 1
        //var stDropout = DateTime.Compare(EndDate, GraduationDate);
        var stGraduated = DateTime.Compare(now, GraduationDate);


        if (stNew == -1) return Status;
        else if (stGraduated == -1) return Status.Active;
        //else if (stDropout == -1) return Status.Dropout;
        else if (stGraduated == 1) return Status.Graduated;
        else return Status.Dropout;

    }

    public void setEndDate() => EndDate = DateTime.Now;
}
