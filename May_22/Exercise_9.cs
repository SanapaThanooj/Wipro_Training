using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     class Studentt
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            
            students.Add("Alice", 85);
            students.Add("Bob", 92);
            students.Add("Charlie", 78);
            students.Add("David", 88);
            students.Add("Eve", 95);


            double average = students.Values.Average();
            Console.WriteLine($"Average Marks: {average}");
            
            var aboveAverageStudents = students.Where(s => s.Value > average).ToList();
            Console.WriteLine("Students above average:");
            foreach (var student in aboveAverageStudents)
            {
                Console.WriteLine($"Name: {student.Key}, Marks: {student.Value}");
            }

        }

    }
}
