using System;
using System.Collections.Generic;

namespace EmployeeSalaryManagement
{
   
    public class Employee
    {
        public int EmployeeID;
        public string Name;
        public decimal Salary;

        public Employee(int id, string name, decimal salary)
        {
            EmployeeID = id;
            Name = name;
            Salary = salary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee(1, "John", 50000));
            employees.Add(new Employee(2, "Emma", 62000));
            employees.Add(new Employee(3, "Liam", 71000));
            employees.Add(new Employee(4, "Olivia", 68000));
            employees.Add(new Employee(5, "Noah", 73000));

           
            Employee highestPaid = employees[0];
            foreach (Employee emp in employees)
            {
                if (emp.Salary > highestPaid.Salary)
                {
                    highestPaid = emp;
                }
            }

            Console.WriteLine($"Highest Paid Employee: {highestPaid.Name}, Salary: {highestPaid.Salary:C}");

          
            Dictionary<int, string> empDictionary = new Dictionary<int, string>();
            foreach (Employee emp in employees)
            {
                empDictionary.Add(emp.EmployeeID, emp.Name);
            }

            
            Console.WriteLine("\nEmployee Directory:");
            foreach (var item in empDictionary)
            {
                Console.WriteLine($"ID: {item.Key}, Name: {item.Value}");
            }

            
            Console.WriteLine("\nEnter Employee ID to search: ");
            string input = Console.ReadLine();
            int searchId;

            if (int.TryParse(input, out searchId))
            {
                if (empDictionary.ContainsKey(searchId))
                {
                    Console.WriteLine($"Employee Found: {empDictionary[searchId]}");
                }
                else
                {
                    Console.WriteLine("Employee ID not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric ID.");
            }
        }
    }
}
