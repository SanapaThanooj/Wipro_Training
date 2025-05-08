using System;
using System.Collections.Generic;
class Empolyees 
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // Create a list of integers
        List<Empolyees> employee = new List<Empolyees> { };         
        employee.Add(new Empolyees { Name = "John", Age = 30 });
        employee.Add(new Empolyees { Name = "Jane", Age = 25 });
         employee.Add(new Empolyees { Name = "suri", Age = 31 });
        employee.Add(new Empolyees { Name = "suman", Age = 32 });
        employee.Add(new Empolyees { Name = "suman", Age = 34 });
       
        employee.Remove(new Empolyees { Name = "suman", Age = 34 });
        // check if the list contains a specific Name

        string spname = "suman";
        bool contains = employee.Any(employee => employee.Name == spname);
        if (contains)
        {
            Console.WriteLine($"The list contains an employee with the name {spname}.");
        }
        else
        {
            Console.WriteLine($"The list does not contain an employee with the name {spname}.");
        }
        //print the list of employees
        foreach (var emp in employee)
        {
            Console.WriteLine($"Name: {emp.Name}, Age: {emp.Age}");
        }
    }
}