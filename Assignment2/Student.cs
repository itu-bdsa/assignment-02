public class Student
{
    int id { get; set;}
    public string givenName{ get; set;}
    string surname; //{ get; set;} 
    DateTime startDate { get; set;} 
    DateTime endDate;
    DateTime graduationDate;
    Status status;


}

public enum Status{}