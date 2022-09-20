public class Student
{
    public int Id { get; init; }
    public string? GivenName { get; set; }
    public string? Surname { get; set; }
    public Status Status { get; set; }
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; set; }
    public DateTime GraduationDate { get; set; }

    public override string ToString(){
        return $"ID: {Id}, Name: {GivenName} {Surname}, Status: {Status}, StartDate: {StartDate}";
    }
}
