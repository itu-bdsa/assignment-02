namespace Assignment2.Tests; 
public class ImmutableTest
{


    [Fact]
    public void EqualComparerTest()
    {
        // Given
         var startDate = new DateTime(2019, 09, 13);
        var endDate = new DateTime(2023, 10, 23);
        var gradDate = new DateTime(2023, 10, 23);

        // Given
  ImuttableStudent student1 = new ImuttableStudent(22, "Asger", "asjo", startDate, endDate, gradDate);
  ImuttableStudent student2 = new ImuttableStudent(22, "Asger", "asjo", startDate, endDate, gradDate);
    
        // When
        bool EqualComparerTest=student1.Equals(student2); 
        // Then
        EqualComparerTest.Should().Be(true);
    }

   [Fact]
    public void testTostring()
    {
        var startDate = new DateTime(2019, 09, 13);
        var endDate = new DateTime(2023, 10, 23);
        var gradDate = new DateTime(2023, 10, 23);

        // Given
  ImuttableStudent student = new ImuttableStudent(22, "Asger", "asjo", startDate, endDate, gradDate);
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
        ImuttableStudent student = new ImuttableStudent(22, "Asger", "asjo", startDate, endDate, gradDate);

        // When
        var status = student.status();

        // Then
        status.Should().Be(Assignment2.ImuttableStudent.Status.Active);
    }
    [Fact]
    public void Testdropoutstatus()
    {
        var startDate = new DateTime(2010, 05, 1);
        var endDate = new DateTime(2011, 01, 2);
        var gradDate = new DateTime(2013, 08, 10);
        // Given
        ImuttableStudent student = new ImuttableStudent(20, "sofus", "sof", startDate, endDate, gradDate);
        // When
        var status = student.status();

        // Then
        status.Should().Be(Assignment2.ImuttableStudent.Status.Dropout);
    }


    [Fact]
    public void Testgradstatus()
    {
        var startDate = new DateTime(2010, 05, 1);
        var endDate = new DateTime(2013, 08, 10);
        var gradDate = new DateTime(2013, 08, 10);
        // Given
        ImuttableStudent student = new ImuttableStudent(30, "Anton", "Anto", startDate, endDate, gradDate);
        // When
        var status = student.status();

        // Then
        status.Should().Be(Assignment2.ImuttableStudent.Status.Graduated);
    }
    [Fact]
    public void TestNewStatus()
    {
        var startDate = new DateTime(2023, 05, 1);
        var endDate = new DateTime(2028, 08, 10);
        var gradDate = new DateTime(2028, 08, 10);
        // Given
        ImuttableStudent student = new ImuttableStudent(25, "louise", "loui", startDate, endDate, gradDate);
        // When
        var status = student.status();

        // Then
        status.Should().Be(Assignment2.ImuttableStudent.Status.New);
    }
}



