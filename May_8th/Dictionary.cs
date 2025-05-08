using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();
        // Adding elements to the dictionary
        students.Add(101, "kirshna");
        students.Add(102, "suresh");
        students.Add(103, "ramesh");

        Console.Write("Student With ID 102 : " + students[102] + " ");

        foreach (var student in students)
        {
            Console.WriteLine("ID : " + student.Key + " Name : " + student.Value);
        }

    }
}