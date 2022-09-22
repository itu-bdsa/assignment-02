 namespace Assignment2; 
 //Only runs when Program.cs doesn't run. It's purpose was just to try and create a student class. 
  class StudentMain
    {
         static void Main(string[] args)
        {
            var StartDate = new DateTime(2021, 10, 13);
            var EndDate = new DateTime(2026, 04, 21);
            var GraduationDate = new DateTime(2026, 04, 21);
            Student student = new Student(2300,"Anna", "Ana", StartDate, EndDate, GraduationDate);
            
            Console.WriteLine(student.ToString());
        }
    }