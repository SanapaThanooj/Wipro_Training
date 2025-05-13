namespace Linq_Practices
{
    // This is a custom delegate that takes a string parameter and returns void
    delegate void CustomDel(string s);
    class Program
    {
        // This is a custom delegate that takes a string parameter and returns void
        // The delegate can point to any method that matches its signature
        static void Hello(string s)
        {
            Console.WriteLine($"Hello, {s}!");
        }
        static void Goodbye(string s)
        {
            Console.WriteLine($"Goodbye, {s}!");
        }
        static void Main()
        {
            // Create a custom delegate instance
            CustomDel hiDel,byeDel,MultiDel,multiMinushiDel;
            hiDel = Hello;
            //Create the delegateObject byeDel that references the Goodbye method
            byeDel = Goodbye;
            // Create a multicast delegate that combines the two delegates
            MultiDel = hiDel + byeDel;
             multiMinushiDel = MultiDel - hiDel; ;

            Console.WriteLine("Invoking delegate hiDel:");
            hiDel("A");
            Console.WriteLine("Invoking delegate byeDel:");
            byeDel("B");
            Console.WriteLine("Invoking delegate MultiDel:");
            MultiDel("C");
            Console.WriteLine("Invoking delegate multiMinushiDel:");
            multiMinushiDel("D");
        }

    }
}