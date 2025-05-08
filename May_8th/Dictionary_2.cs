class Program
{
    static void Main()
    {
        Dictionary<int, string> employee = new Dictionary<int, string>{
            {1,"Rohit"},
            {2,"Ravi"},
            {3,"Ramesh"},

        };
        // Updating the namwe of student with ID 2
        employee[2] = "Ravi Kumar";

        Console.Write("Student With ID 2 : " + employee[2] + " ");

        Console.WriteLine("\n\nupdated List of Employees : ");
        foreach (var emp in employee)
        {
            Console.WriteLine("ID : " + emp.Key + " Name : " + emp.Value);
        }

    }
}