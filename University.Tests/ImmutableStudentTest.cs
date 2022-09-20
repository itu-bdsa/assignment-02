namespace University.Tests;

public class ImmutableStudentTest
{

    [Fact]
    public void Equality_same()
    {
        var student1 = new ImmutableStudent(1, "John", "Doe", StudentStatus.New, new DateTime(2020, 01, 01), new DateTime(2022, 01, 01), new DateTime(2023, 01, 01));
        var student2 = new ImmutableStudent(1, "John", "Doe", StudentStatus.New, new DateTime(2020, 01, 01), new DateTime(2022, 01, 01), new DateTime(2023, 01, 01));

        student1.Equals(student2).Should().BeTrue();
    }

    [Fact]
    public void Equality_different_first_smaller()
    {
        var student1 = new ImmutableStudent(1, "John", "Doe", StudentStatus.Graduated, new DateTime(2020, 01, 01), new DateTime(2022, 01, 01), new DateTime(2023, 01, 01));
        var student2 = new ImmutableStudent(2, "John", "Doe", StudentStatus.Dropout, new DateTime(2020, 01, 01), new DateTime(2022, 01, 01), new DateTime(2023, 01, 01));

        student1.Equals(student2).Should().BeFalse();
    }

    [Fact]
    public void Equality_different_first_larger()
    {
        var student1 = new ImmutableStudent(2, "John", "Doe", StudentStatus.Active, new DateTime(2020, 01, 01), new DateTime(2022, 01, 01), new DateTime(2023, 01, 01));
        var student2 = new ImmutableStudent(1, "John", "Doe", StudentStatus.New, new DateTime(2020, 01, 01), new DateTime(2022, 01, 01), new DateTime(2023, 01, 01));
        student1.Equals(student2).Should().BeFalse();
    }

    [Fact]
    public void Record_ToString()
    {
        var student = new ImmutableStudent(1, "John", "Doe", StudentStatus.New, new DateTime(2020, 01, 01), new DateTime(2022, 01, 01), new DateTime(2023, 01, 01));
        var toString = student.ToString();

        toString.Should().Be("ImmutableStudent { Id = 1, GivenName = John, Surname = Doe, Status = New, StartDate = 01-01-2020 00:00:00, EndDate = 01-01-2022 00:00:00, GraduationDate = 01-01-2023 00:00:00 }");
    }

}