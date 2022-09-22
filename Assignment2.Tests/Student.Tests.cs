namespace Assignment2.Tests;

public class StudentTest
{


    [Fact]
    public void testTostring()
    {
        var startDate = new DateTime(2019, 09, 13);
        var endDate = new DateTime(2023, 10, 23);
        var gradDate = new DateTime(2023, 10, 23);

        // Given
    Student student = new Student(22, "Asger", "asjo", startDate, endDate, gradDate);
        // When
    var output=student.ToString();
        // Then
    output.Should().Be($"Id: 22, Asger, asjo, Status: Active, Start date: {startDate}, End date: {endDate}, Graduation date: {gradDate}");
    }


    [Fact]
    public void TestActiveStatus()
    {
        var startDate = new DateTime(2019, 09, 13);
        var endDate = new DateTime(2023, 10, 23);
        var gradDate = new DateTime(2023, 10, 23);


        // Given
        Student student = new Student(22, "Asger", "asjo", startDate, endDate, gradDate);

        // When
        var status = student.Rules();

        // Then
        status.Should().Be(Assignment2.Student.Status.Active);
    }
    [Fact]
    public void Testdropoutstatus()
    {
        var startDate = new DateTime(2010, 05, 1);
        var endDate = new DateTime(2011, 01, 2);
        var gradDate = new DateTime(2013, 08, 10);
        // Given
        Student student = new Student(20, "sofus", "sof", startDate, endDate, gradDate);
        // When
        var status = student.Rules();

        // Then
        status.Should().Be(Assignment2.Student.Status.Dropout);
    }


    [Fact]
    public void Testgradstatus()
    {
        var startDate = new DateTime(2010, 05, 1);
        var endDate = new DateTime(2013, 08, 10);
        var gradDate = new DateTime(2013, 08, 10);
        // Given
        Student student = new Student(30, "Anton", "Anto", startDate, endDate, gradDate);
        // When
        var status = student.Rules();

        // Then
        status.Should().Be(Assignment2.Student.Status.Graduated);
    }
    [Fact]
    public void TestNewStatus()
    {
        var startDate = new DateTime(2023, 05, 1);
        var endDate = new DateTime(2028, 08, 10);
        var gradDate = new DateTime(2028, 08, 10);
        // Given
        Student student = new Student(25, "louise", "loui", startDate, endDate, gradDate);
        // When
        var status = student.Rules();

        // Then
        status.Should().Be(Assignment2.Student.Status.New);
    }
}
