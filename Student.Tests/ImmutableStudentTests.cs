namespace Student.Tests;

public class ImmutableStudentTests
{
    [Fact]
    public void ImmutableStudent_toString()
    {
        // Arrange
        var immutStudent = new ImmutableStudent(1, "Gert", "Sørensen", new DateTime(2018, 01, 01), null, new DateTime(2025, 01, 01));
        var expected = "ImmutableStudent { Id = 1, GivenName = Gert, Status = Active, Surname = Sørensen, StartDate = 1/1/2018 12:00:00 AM, EndDate = , GraduationDate = 1/1/2025 12:00:00 AM }";
        // Act
        var actual = immutStudent.ToString();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void ImmutableStudent_with_equal_values_should_be_equal()
    {
        // Arrange

        var immutStudent1 = new ImmutableStudent(1, "Gert", "Sørensen", new DateTime(2018, 01, 01), null, new DateTime(2025, 01, 01));

        var immutStudent2 = new ImmutableStudent(1, "Gert", "Sørensen", new DateTime(2018, 01, 01), null, new DateTime(2025, 01, 01));

        // Assert
        immutStudent1.Should().BeEquivalentTo(immutStudent2);
    }
}

