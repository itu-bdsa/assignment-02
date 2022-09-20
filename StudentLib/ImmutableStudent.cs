namespace Assignment2.StudentLib;
public record ImmutableStudent(int id, string givenName, string surName, Status status, DateTime startDate, DateTime endDate, DateTime graduationDate)
{

    public override string ToString()
    {
        return $"ID: {id}, Name: {givenName} {surName}, Status: {status}, StartDate: {startDate}, EndDate: {endDate}, GraduationDate: {graduationDate}";
    }

}


