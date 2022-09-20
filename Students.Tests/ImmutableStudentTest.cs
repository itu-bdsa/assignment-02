namespace Students.Tests;
public class ImmutableStudentTest
{
    [Fact]
    public void ImmmutableStudent_Active_ToString()
    {
        var s = new ImmutableStudent(1, "Silas", "Arildsen", new DateTime(2021, 8, 1), new DateTime(2024, 6, 1), new DateTime(2024, 6, 1));
        var expected = "Silas Arildsen, ID: 1. Start: 01/08/2021. Status: Active. Graduates: 01/06/2024.";
        s.Should().Be(expected);
    }

    [Fact]
    public void ImmmutableStudent_Graduated_ToString()
    {
        var s = new ImmutableStudent(1, "Silas", "Arildsen", new DateTime(2016, 8, 1), new DateTime(2019, 6, 1), new DateTime(2019, 6, 1));
        var expected = "Silas Arildsen, ID: 1. Start: 01/08/2016. Status: Graduated. Graduates: 01/06/2019.";
        s.Should().Be(expected);
    }
}