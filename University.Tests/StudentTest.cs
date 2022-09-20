using static University.Student;

namespace University.Tests;
public class StudentTests
{

    [Fact]
    public void Student_should_be_dropout()
    {
        var student = new Student(1, "John", "Doe", StartDate: new DateTime(2020, 01, 01), EndDate: new DateTime(2022, 01, 01), GraduationDate: new DateTime(2023, 01, 01));
        student.Status.Should().Be(StudentStatus.Dropout);
    }

    [Fact]
    public void Student_should_be_graduated()
    {
        var currentDate = DateTime.Now;
        var pastDate = currentDate.AddYears(-2);
        var student = new Student(1, "John", "Doe", StartDate: new DateTime(2021, 04, 12), EndDate: pastDate, GraduationDate: pastDate);
        student.Status.Should().Be(StudentStatus.Graduated);
    }

    [Fact]
    public void Student_should_be_active()
    {
        var currentDate = DateTime.Now;
        var futureDate = currentDate.AddYears(3);

        var student = new Student(1, "John", "Doe", StartDate: new DateTime(2020, 01, 01), EndDate: futureDate, GraduationDate: futureDate);
        (student.Status).Should().Be(StudentStatus.Active);
    }

    [Fact]
    public void Student_should_be_new()
    {
        var currentDate = DateTime.Now;
        var futureDate = currentDate.AddYears(1);
        var distantFuture = currentDate.AddYears(5);
        var student = new Student(1, "John", "Doe", StartDate: futureDate, EndDate: distantFuture, GraduationDate: distantFuture);
        student.Status.Should().Be(StudentStatus.New);
    }

}