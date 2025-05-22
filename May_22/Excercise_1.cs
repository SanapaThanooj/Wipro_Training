namespace Algorithms
{
    class Program
    {

        static void Main()
        {
            List<string> students = new List<string>();

            students.Add("Bob");
            students.Add("Charlie");
            students.Add("David");
            students.Add("Eve");
            students.Add("Alice");

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            students.Sort();
            Console.WriteLine("Sorted List:");
            foreach (string student in students)

            {
                Console.WriteLine(student);
            }

        }

    }
}
