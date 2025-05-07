using System.Collections;
class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add("Apple");
        list.Add(42);
        list.Add(3.14);
        //list.Insert(1, "Inserted");
        list.Remove(42);
        list.RemoveAt(0);

        Console.WriteLine("Count after Removal:" + list.Count);
        //Console.WriteLine("Element at Index : 1" + list[1]);

        foreach (var item in list)
        {
            Console.WriteLine(item);

        }
        Console.Read();
    }
}
