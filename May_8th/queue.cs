class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("Amit");
        queue.Enqueue("Vijay");
        queue.Enqueue("Rahul");
        queue.Enqueue("Amit");

        Console.WriteLine("Queue elements:");
        foreach (var name in queue)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine($"\nDequeuet: {queue.Dequeue()}");
        Console.WriteLine("Next in Line " + queue.Peek());

    }
}