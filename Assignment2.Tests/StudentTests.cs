namespace Assignment2.Tests;

public class StudentTests
{
    [Fact]
    public void Test1()
    {
        var stdLst = new List<Student>()
        {
            new Student(0, "Phil", "Larsen", Status.New, DateTime.Now, null, null ),
            new Student();
        }

    }
}