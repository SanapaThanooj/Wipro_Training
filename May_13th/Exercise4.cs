using System;

namespace Linq_Practices
{
    
    public abstract class Employee
    {
        // Abstract method
        public abstract void CalculateSalary();

        // Concrete method
        public void ShowBasicInfo()
        {
            Console.WriteLine("Employee details");
        }
    }

    
    public class FullTimeEmployee : Employee
    {
        private double basicSalary;
        private double allowance;

        public FullTimeEmployee(double basicSalary, double allowance)
        {
            this.basicSalary = basicSalary;
            this.allowance = allowance;
        }

        
        public override void CalculateSalary()
        {
            double totalSalary = basicSalary + allowance;
            Console.WriteLine($"Salary: {totalSalary}");
        }
    }

    public class PartTimeEmployee : Employee
    {
        private double hourlyRate;
        private int hoursWorked;

        public PartTimeEmployee(double hourlyRate, int hoursWorked)
        {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }

        
        public override void CalculateSalary()
        {
            double totalSalary = hourlyRate * hoursWorked;
            Console.WriteLine($"Salary: {totalSalary}");
        }
    }

    
     class Program
    {
        public static void Main(string[] args)
        {
           
            Employee fullTimeEmployee = new FullTimeEmployee(30000, 5000);
            Employee partTimeEmployee = new PartTimeEmployee(150, 20);

            
            fullTimeEmployee.ShowBasicInfo(); 
            fullTimeEmployee.CalculateSalary(); 

            partTimeEmployee.ShowBasicInfo(); 
            partTimeEmployee.CalculateSalary(); 
        }
    }
}