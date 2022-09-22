namespace Assignment2;


public record ImuttableStudent
{
    public enum Status


    {
        New,
        Active,
        Dropout,
        Graduated

    }
    int id { get; init; }

    string givenName { get; init; }
    string surName {get; init; }
    DateTime startDate { get; init; }

    DateTime endDate { get; init; }

    DateTime graduationDate { get; init; }

    public ImuttableStudent(int Id, string givenName, string surName, DateTime startDate, DateTime endDate, DateTime graduationDate)
    {
        this.id=Id;
        this.givenName = givenName;
        this.surName = surName;
        this.startDate = startDate;
        this.endDate = endDate;
        this.graduationDate = graduationDate;




    }
    public Status status()
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
        return $"Id: {id}, {givenName}, {surName}, Status: {status()}, Start date: {startDate}, End date: {endDate}, Graduation date: {graduationDate}";
    }
}