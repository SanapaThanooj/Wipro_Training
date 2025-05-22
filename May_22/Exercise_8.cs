using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Employee_salary
    {
        static void Main(string[] args)
        {
            Dictionary<int, decimal> Salary_lookup = new Dictionary<int, decimal>();

            Salary_lookup.Add(1, 50000);
            Salary_lookup.Add(2, 60000);
            Salary_lookup.Add(3, 70000);
            Salary_lookup.Add(4, 80000);
            Salary_lookup.Add(5, 90000);

            Console.WriteLine("Enter Employee ID To Find:");
            int empId = Convert.ToInt32(Console.ReadLine());
            if (Salary_lookup.ContainsKey(empId))
            {
                Console.WriteLine($"Employee ID: {empId}, Salary: {Salary_lookup[empId]}");
            }
            else
            {
                Console.WriteLine("Employee ID not found.");
            }
        }

    }
}
