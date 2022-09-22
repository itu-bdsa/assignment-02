namespace Assignment2;


public class Student
{
    private int id; 
    private string givenName;
    private string surName;
    private DateTime startDate; 
    private DateTime endDate; 
    private DateTime graduationDate; 
    
    public enum Status


    {
        New,
        Active,
        Dropout,
        Graduated

    }
    public int Id { get => this.id; }
    

    public string GivenName { get => this.givenName; set => this.givenName = value; }
    public string SurName { get => this.surName; set => this.surName = value; }
    DateTime StartDate { get => this.startDate; set => this.startDate = value; }

    DateTime EndDate { get => this.endDate; set => this.endDate = value; }

    DateTime GraduationDate { get => this.graduationDate; set => this.graduationDate = value; }

    public Student(int Id,string givenName,string surName, DateTime startDate, DateTime endDate, DateTime graduationDate)
    {
      this.id=Id;

       this.givenName = givenName;
         this.surName = surName;
         this.startDate = startDate;
         this.endDate = endDate;
         this.graduationDate = graduationDate;




    }
    public Status Rules()
    {
        DateTime local = DateTime.Now;

        var localStart = DateTime.Compare(local, startDate);

        var localEnd = DateTime.Compare(local, endDate);

        var localGrad = DateTime.Compare(local, graduationDate);

        var endGrad = DateTime.Compare(endDate, graduationDate);

        if (localStart == -1) { return Status.New; }


        else if (localStart == 1 && localEnd == -1) { return Status.Active; }

        else if (endGrad == -1 && localEnd == 1) { return Status.Dropout; }

        else { return Status.Graduated; }

    }

    public override string ToString()
    {
        return $"Id: {Id}, {givenName}, {surName}, Status: {Rules()}, Start date: {startDate}, End date: {endDate}, Graduation date: {graduationDate}";
    }
}










