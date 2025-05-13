using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practices
{
     class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
       
    }
}

namespace Linq_Practices
{

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employeesArray = {
            
                new Employee { EmployeeId = 1, EmployeeName = "John", Age = 18 },
                new Employee { EmployeeId = 2, EmployeeName = "Jane", Age = 20 },
                new Employee { EmployeeId = 3, EmployeeName = "Sam", Age = 15 },
                new Employee { EmployeeId = 4, EmployeeName = "Sara", Age = 16 },
                new Employee { EmployeeId = 5, EmployeeName = "Bill", Age = 22 },
                new Employee { EmployeeId = 6, EmployeeName = "Tom", Age = 18 },
                new Employee { EmployeeId = 7, EmployeeName = "Jerry", Age = 19 },
            };
            //Employee[] employees = new Employee[10];

            //    int i = 0;
            //    foreach (var employee in employeesArray)
            //    {
            //        if (employee.Age > 12 && employee.Age < 30)
            //        {
            //            employees[i] = employee;
            //        Console.WriteLine($"EmployeeId: {employee.EmployeeId}, EmployeeName: {employee.EmployeeName}, Age: {employee.Age}");
            //        i++;
            //        }
            //    }
            Employee[] teenAgeEmplyees = employeesArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

            foreach (var employees in teenAgeEmplyees)
            {
                Console.WriteLine($"EmployeeId: {employees.EmployeeId}, EmployeeName: {employees.EmployeeName}, Age: {employees.Age}");
            }

            Employee bill =  employeesArray.Where(s => s.EmployeeName == "Bill").FirstOrDefault();

            if (bill != null)
            {
                Console.WriteLine($"EmployeeId: {bill.EmployeeId}, EmployeeName: {bill.EmployeeName}, Age: {bill.Age}");
            }
            else
            {
                Console.WriteLine("Employee not found");
            }


            Employee employee = employeesArray.Where(s => s.EmployeeId == 4).FirstOrDefault();
            if (employee != null)
            {
                Console.WriteLine($"EmployeeId: {employee.EmployeeId}, EmployeeName: {employee.EmployeeName}, Age: {employee.Age}");
            }
            else
            {
                Console.WriteLine("Employee not found");
            }

        }
       
    }
}
