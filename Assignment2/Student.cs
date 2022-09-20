public class Student
{
    int id { get; set;}
    public string givenName { get; set;} = null!;
    string surname { get; set;} = null!;
    DateTime startDate { get; set;} 

    DateTime endDate;
    DateTime graduationDate;
    Status status;


}

public enum Status{}