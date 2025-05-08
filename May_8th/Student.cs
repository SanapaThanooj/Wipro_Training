using System;
using System.Collections.Generic;
class Program
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    static void Main()
    {
        List<Student> students = new List<Student> {
            new Student { ID = 1, Name = "John" },
            new Student { ID = 2, Name = "Jane" }
       };
        students.Add(new Student { ID = 3, Name = "Sam" });
        // Display the students
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}");


        }
    }
}

