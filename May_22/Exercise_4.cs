using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     class Students
    {
        public string Name { get; set; }

        public int Marks { get; set; }
    }
    class Program
    {
        static void Main()
        {
            List<Students> students = new List<Students>
            {
                new Students { Name = "Alice", Marks = 85 },
                new Students { Name = "Bob", Marks = 92 },
                new Students { Name = "Charlie", Marks = 78 },
                new Students { Name = "David", Marks = 88 },
                new Students { Name = "Eve", Marks = 95 }

            };
            students.Sort((x, y) => y.Marks.CompareTo(x.Marks));
            Console.WriteLine("Top 3 Students:");
            for (int i = 0;i<3 && i < students.Count;i++)
            {
                Console.WriteLine($"Name: {students[i].Name}, Marks: {students[i].Marks}");
            }
        }
    }
}
