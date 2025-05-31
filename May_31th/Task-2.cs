using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
     class Employee 
    {
        List<Employee> employees = new List<Employee>();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public Employee(int id, string name, string department, double salary)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee(1, "Alice", "HR", 50000),
                new Employee(2, "Bob", "IT", 60000),
                new Employee(3, "Charlie", "Finance", 55000)
            };
            var itEmployees = employees.Where(e => e.Department == "IT");
           Console.WriteLine("Employees in IT Department:");
            foreach (var emp in itEmployees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
            }
           
            var SortedOrder = employees.OrderByDescending(e => e.Salary );
            Console.WriteLine("\nEmployees Sorted by Salary in Descending Order:");
            foreach (var emp in SortedOrder)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
            }
            var averageSalary = employees.GroupBy(e => e.Department).Select(g => new { Department = g.Key, AverageSalary = g.Average(e => e.Salary) });
                                         
            Console.WriteLine($"\nAverage Salary : {averageSalary}");
            foreach (var group in averageSalary)
            {
                Console.WriteLine($"Department: {group.Department}, Average Salary: {group.AverageSalary}");
            }
        }
    }
}
