using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
     class students
    {
        static void Main()
        {
            var students = new Dictionary<string,List<int>>
            {
                ["Alice"] = new List<int> { 85, 90, 78 },
                ["Bob"] = new List<int> { 88, 92, 80 },
                ["Charlie"] = new List<int> { 95, 89, 84 },
                ["David"] = new List<int> { 76, 85, 90 }
               
            };
            foreach (var s in students)
            {
                var avg = s.Value.Average();
                var scores = s.Value.Max();
                var min = s.Value.Min();
                Console.WriteLine($"Average: {avg}, Scores: {scores}, Mim :{min}");
            }
            Console.WriteLine("\nTop 3 scorers by average score:");
            var topScorers = students.OrderByDescending(s => s.Value.Average()).Take(3);
            foreach (var student in topScorers)
            {
                Console.WriteLine($"{student.Key}: {student.Value.Average()}");
            }
        }
    }
}
