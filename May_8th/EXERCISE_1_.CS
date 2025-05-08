using System.Collections;
class Program
{
    static void Main()
    {
        ArrayList student = new ArrayList();

        student.Add("Ramesh");
        student.Add("veera");
        student.Add("suresh");
        student.Add("srinivas");
        student.Add("vinesh");
        student.RemoveAt(1);
        Console.WriteLine(" Names list :");

        foreach (var book in student)
        {
            Console.WriteLine(book);
        }
        string name = "suresh";
        if (student.Contains("name"))
        {
            Console.WriteLine("suresh is present in the list");
        }
        else
        {
            Console.WriteLine("suresh is not present in the list");
        }

    }
}