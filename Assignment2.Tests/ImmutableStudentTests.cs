namespace Assignment2.Tests;

public class ImmutableStudentTests
{
    [Fact]
    public void ToString_dropout()
    {
        //Arrange
        var student = new ImmutableStudent(
            1,
            "Jens",
            "Jensen",
            new DateTime(2019, 8, 23),
            new DateTime(2021, 6, 16),
            new DateTime(2022, 6, 16)
        );
        //Assert
        student.ToString().Should().Be("ImmutableStudent { Id = 1, GivenName = Jens, Surname = Jensen, StartDate = 23-08-2019 00:00:00, EndDate = 16-06-2021 00:00:00, GraduationDate = 16-06-2022 00:00:00, Status = Dropout }");
    }

    [Fact]
    public void Equality()
    {
        //Arrange
        var student = new ImmutableStudent(
            1,
            "Jens",
            "Jensen",
            new DateTime(2019, 8, 23),
            new DateTime(2021, 6, 16),
            new DateTime(2022, 6, 16)
        );

        var student2 = student with { };
        var equality = Object.Equals(student, student2);
        var referenceequality = Object.ReferenceEquals(student, student2);
        //Assert
        equality.Should().BeTrue();
        referenceequality.Should().BeFalse();
    }
}