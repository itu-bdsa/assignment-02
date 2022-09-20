namespace Student;

public record ImmutableStudent
{
  public int Id { get; init; }
  public string GivenName { get; init; }
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
  public string Surname { get; init; }
  public DateTime StartDate { get; init; }
  public DateTime? EndDate { get; init; }
  public DateTime GraduationDate { get; init; }


  public ImmutableStudent(int id, string givenName, string surname, DateTime startDate, DateTime? endDate, DateTime graduationDate)
  {
    Id = id;
    GivenName = givenName;
    Surname = surname;
    StartDate = startDate;
    EndDate = endDate;
    GraduationDate = graduationDate;
  }
}

