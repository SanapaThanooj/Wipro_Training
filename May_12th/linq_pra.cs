namespace Linq_Practices
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "John", "Jane", "Jack", "Jill", "James", "Jasmine", "bittu","Judy", "Jordan", "Jessica" };
            UsingLinq(names);
        }
        private static void UsingLinq(string[] names)
        {
            IEnumerable<string> query = from s in names
                                        where s.Length == 5
                                        orderby s
                                        select s.ToUpper();

            foreach (var name in query)
            {
                Console.WriteLine(name);
            }

            Console.Read();
        }
    }
}