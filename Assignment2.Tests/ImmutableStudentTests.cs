namespace Assignment2.Tests;

public class ImmutableStudentTests
{
    [Fact]
    public void ToString_dropout()
    {
        //Arrange
        var actual = new ImmutableStudent(
            id: 1,
            givenname: "Jens",
            surname: "Jensen",
            startdate: new DateTime(2019, 8, 23),
            enddate: new DateTime(2021, 6, 16),
            graduationdate: new DateTime(2022, 6, 16)
        );
        //Assert
        actual.ToString().Should().Be("ImmutableStudent { Id = 1, GivenName = Jens, Surname = Jensen, Status = Dropout, StartDate = 23-08-2019 00:00:00, EndDate = 16-06-2021 00:00:00, GraduationDate = 16-06-2022 00:00:00 }");
    }

    [Fact]
    public void Equality()
    {
        //Arrange
        var student = new ImmutableStudent(
            id: 1,
            givenname: "Jens",
            surname: "Jensen",
            startdate: new DateTime(2019, 8, 23),
            enddate: new DateTime(2021, 6, 16),
            graduationdate: new DateTime(2022, 6, 16)
        );

        var student2 = student with { };
        var equality = Object.Equals(student, student2);
        var referenceequality = Object.ReferenceEquals(student, student2);
        
        //Assert
        equality.Should().BeTrue();
    }
}