class Employees
{
    public int EmployeeId;
    public string Name;
    public string Department;
    public double Salary;
    public void PrintDetails()
    {
        Console.WriteLine("Employee ID: " + EmployeeId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("Salary: " + Salary);
    }
    public void AnnualSalary()
    {
        double Annual_salary = Salary * 12;
        Console.WriteLine("Annual Salary: " + Annual_salary);
    }
    public void UpdateSalary(double newSalary)
    {
        if (Salary >= 0)
        {
            Salary = newSalary;
            Console.WriteLine("Updated Salary: " + Salary);
        }
        else
        {
            Console.WriteLine("Invalid Salary");
        }
    }
}
//using may_7;
namespace may_7
{
    class Program
    {
        static void Main()
        {

            Employees employee = new Employees { EmployeeId = 101, Name = "Neha", Department ="HR",Salary =50000.00 };



            /*student1.RollNumber = 1;
            student1.Name = "Sanapa Thanooj Prapulla";
            student1.Marks = 85; */
            employee.PrintDetails();
            employee.AnnualSalary();
            employee.UpdateSalary(55000);

        }
    }
}
