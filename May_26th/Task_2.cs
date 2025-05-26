using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    internal class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public string Grades { get; set; }

    }
    public class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", Marks = 85, Grades = "A" },
                new Student { Name = "Bob", Marks = 70, Grades = "B" },
                new Student { Name = "Charlie", Marks = 90, Grades = "A" },
                new Student { Name = "David", Marks = 60, Grades = "C" },
                new Student { Name = "Eve", Marks = 75, Grades = "B" },
                new Student { Name = "Frank", Marks = 55, Grades = "D" },
                new Student { Name = "Grace", Marks = 95, Grades = "A" },
                new Student { Name = "Hank", Marks = 80, Grades = "B" },
                new Student { Name = "Ivy", Marks = 65, Grades = "C" },
                new Student { Name = "Jack", Marks = 50, Grades = "D" }

            };
            // Using LINQ to filter students
            var filteredStudents = students.OrderByDescending(s => s.Marks);

            // Displaying the filtered students
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Marks}, Address: {student.Grades}");
            }
            Console.WriteLine("\nGround by Grade");
            var GroupedGrade = students.GroupBy(s => s.Grades);
            foreach (var group in GroupedGrade)
            {
                Console.WriteLine($"Grade: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"  Name: {student.Name}, Marks: {student.Marks}");
                }
            }
            Console.WriteLine("\nTop 3 Students:");
            var topStudents = students.Take(3);
            foreach (var student in topStudents)
            {
                Console.WriteLine($"Name: {student.Name}, Marks: {student.Marks}, Grades: {student.Grades}");
            }
        }
    }



}
