namespace Linq_Practices
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "John", "Jane", "Jack", "Jill", "James", "Jasmine", "bittu","Judy", "Jordan", "Jessica" };
            //UsingLinq(names);
            //  UsingLINQFunctions(names);
            UsingAnonymousTypes(names);
        }
        //private static void UsingLinq(string[] names)
        //{
        //    IEnumerable<string> query = from s in names
        //                                where s.Length == 5
        //                                orderby s
        //                                select s.ToUpper();

        //    foreach (var name in query)
        //    {
        //        Console.WriteLine(name);
        //    }

        //    Console.Read();
        //}
        //private static void UsingLinq(string[] names)
        //{
        //    IEnumerable<string> query = names
        //        .Where(s=> s.Length == 5)
        //        .OrderBy(s => s)
        //        .Select(s => s.ToUpper());

        //    foreach (var name in query)
        //    {
        //        Console.WriteLine(name);
        //    }
        //    Console.Read();
        //}
        //private static void UsingLINQFunctions(string[] names)
        //{
        //    Func<string, bool> filter = s => s.Length == 5;
        //    Func<string, string> extract = s => s;
        //    Func<string , string> project = s => s.ToUpper();

        //    IEnumerable<string> query = names.Where(filter)
        //        .OrderBy(extract)
        //        .Select(project);
        //    foreach (var item in query)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.Read();
        //}
        private static void UsingAnonymousTypes(string[] names)
        {
            Func<string, bool> filter = delegate (string s)
            {
                return s.Length == 5;
            };
            Func<string, string> extract = delegate (string s)
            {
                return s;
            };
            Func<string, string> project = delegate (string s)
            {
                return s.ToUpper();
            };
            IEnumerable<string> query = names.Where(filter)
                .OrderBy(extract)
                .Select(project);
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}