namespace Assignment2.Tests;
using Assignment2.StudentLib;

public class StudentTests
{
    [Fact]
    public void Student_getStatus_givenDateNow_is_within5days_returnEnumNew()
    {
        Student una = new Student("Una", "Langeland");
        Status expectedNEW = Status.New;

        Assert.Equal(expectedNEW, una.getStatus());
    }


    [Fact]
    public void Student_toString_givenStudent_returnString()
    {
        Student philip = new Student("Philip", "Larsen");

        string expected = $"ID: {philip.Id}, Name: Philip Larsen, Status: New, StartDate: {philip.StartDate}, GraduationDate: {philip.GraduationDate}";

        Assert.Equal(expected, philip.ToString());
    }

    [Fact]
    public void immuStuTest()
    {
        var philip = new ImmutableStudent(3, "John", "Doe", Status.New, DateTime.Now,
                                                DateTime.Now.AddDays(25), DateTime.Now.AddYears(3));

        string expected = $"ID: {3}, Name: John Doe, Status: New, StartDate: {philip.startDate}, EndDate: {philip.endDate}, GraduationDate: {philip.graduationDate}";

        Assert.Equal(expected, philip.ToString());
    }
}