using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     class Employee
    {
        public string name { get; set; }
        public string Department { get; set; }
        
    }
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { name = "Alice", Department = "HR" },
                new Employee { name = "Bob", Department = "IT" },
                new Employee { name = "Charlie", Department = "Finance" },
                new Employee { name = "David", Department = "IT" },
                new Employee { name = "Eve", Department = "HR" },
                new Employee { name = "Frank", Department = "Finance" }
            };
            
            var groupedByDepart = employees.GroupBy(e => e.Department);
            foreach (var group in groupedByDepart)
            {
                Console.WriteLine($"Department :{group.Key}");
                foreach (var emp in group) Console.WriteLine($" - {emp.name}");
            }
        }
    }
}
