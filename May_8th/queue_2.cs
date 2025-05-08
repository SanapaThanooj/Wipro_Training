class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("Amit");
        queue.Enqueue("Vijay");
        queue.Enqueue("Rahul");
        queue.Enqueue("kumar");

        Console.WriteLine("Serving Customers:");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }

    }
}