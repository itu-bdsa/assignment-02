namespace Student.Tests;

public class StudentTests
{
    [Fact]
    public void Student_status_should_be_new_if_not_started()
    {
        var student = new Student(3, "Gert", "Sørensen", new DateTime(2023, 09, 01), null, new DateTime(2026, 07, 30));
        var status = student.Status;


    }

    [Fact]
    public void Student_status_should_be_active()
    {
        // Arrange
        var student = new Student(3, "Gert", "Sørens test the built-in equality cen", new DateTime(2020, 01, 01), null, new DateTime(2025, 01, 01));

        // Act
        var status = student.Status;

        // Assert
        status.Should().Be(Active);
    }

    [Fact]
    public void Student_status_should_be_dropout()
    {
        // Arrange
        var student = new Student(3, "Gert", "Sørensen", new DateTime(2020, 01, 01), new DateTime(2020, 02, 01), new DateTime(2025, 01, 01));

        // Act
        var status = student.Status;

        // Assert
        status.Should().Be(Dropout);
    }

    [Fact]
    public void Student_status_should_be_graduated()
    {
        // Arrange
        var student = new Student(3, "Gert", "Sørensen", new DateTime(2016, 01, 01), new DateTime(2019, 01, 01), new DateTime(2019, 01, 01));

        // Act
        var status = student.Status;

        // Assert
        status.Should().Be(Graduated);
    }

    [Fact]
    public void Student_has_nice_ToString()
    {
        // Arrange
        var student = new Student(123, "Gert", "Sørensen", new DateTime(2016, 01, 01), new DateTime(2019, 01, 01), new DateTime(2019, 01, 01));

        // Act
        var expected = "[123] Gert Sørensen | Graduated";
        var actual = student.ToString();

        // Assert
        actual.Should().Be(expected);
    }
}

