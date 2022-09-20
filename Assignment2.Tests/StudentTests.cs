namespace Assignment2.Tests;

public class StudentTests
{
    //Since we use DateTime.Now in the FindStatus method these tests will become outdated eventually and therefore fail

    [Fact]
    public void Student_status_returns_graduated()
    {
        var actual = new Student()
        {
            Id = 1,
            GivenName = "Jens",
            Surname = "Jensen",
            StartDate = new DateTime(2019, 8, 23),
            EndDate = new DateTime(2022, 6, 16),
            GraduationDate = new DateTime(2022, 6, 16)
        };
        //Assert
        actual.Status.Should().Be(Status.Graduated);
    }

    [Fact]
    public void Student_status_returns_new()
    {
        //Act
        var actual = new Student()
        {
            Id = 1,
            GivenName = "Jens",
            Surname = "Jensen",
            StartDate = new DateTime(2023, 8, 23),
            EndDate = new DateTime(2026, 6, 16),
            GraduationDate = new DateTime(2026, 6, 16)
        };
        //Assert
        actual.Status.Should().Be(Status.New);
    }

    [Fact]
    public void Student_status_returns_dropout()
    {
        //Arrange
        var actual = new Student()
        {
            Id = 1,
            GivenName = "Jens",
            Surname = "Jensen",
            StartDate = new DateTime(2019, 8, 23),
            EndDate = new DateTime(2021, 6, 16),
            GraduationDate = new DateTime(2022, 6, 16)
        };
        //Assert
        actual.Status.Should().Be(Status.Dropout);
    }

    [Fact]
    public void Student_status_returns_active()
    {
        var actual = new Student()
        {
            Id = 1,
            GivenName = "Jens",
            Surname = "Jensen",
            StartDate = new DateTime(2020, 8, 23),
            EndDate = new DateTime(2023, 6, 16),
            GraduationDate = new DateTime(2023, 6, 16)
        };
        //Assert
        actual.Status.Should().Be(Status.Active);
    }

    [Fact]
    public void Student_ToString()
    {
        var actual = new Student()
        {
            Id = 1,
            GivenName = "Jens",
            Surname = "Jensen",
            StartDate = new DateTime(2020, 8, 23),
            EndDate = new DateTime(2023, 6, 16),
            GraduationDate = new DateTime(2023, 6, 16)
        };
        //Assert
        actual.ToString().Should().Be("Jens Jensen with ID 1 is active");
    }

    [Fact]
    public void Student_ToString_dropout()
    {
        //Arrange
        var actual = new Student()
        {
            Id = 1,
            GivenName = "Jens",
            Surname = "Jensen",
            StartDate = new DateTime(2019, 8, 23),
            EndDate = new DateTime(2021, 6, 16),
            GraduationDate = new DateTime(2022, 6, 16)
        };
        //Assert
        actual.ToString().Should().Be("Jens Jensen with ID 1 is a dropout");
    }
}