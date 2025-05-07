using System.Collections;
using System;
class Program
{
    static void Main()
    {
        ArrayList students = new ArrayList();
        students.Add("John");
        students.Add("Jane");
        students.Add("Doe");
        students.Add("Smith");
        students.Add("Alice");
        Console.WriteLine("Students in the list:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
        string nameToFind = "Doe";
        if (students.Contains(nameToFind))
        {
            Console.WriteLine($"{nameToFind} is in the list.");
        }
        else
        {
            Console.WriteLine($"{nameToFind} is not in the list.");
        }

        students.RemoveAt(1);

        Console.WriteLine("After removing the second student:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
        Console.Read();

    }
}
