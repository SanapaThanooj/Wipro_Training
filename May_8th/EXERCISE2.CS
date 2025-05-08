using System;
using System.Collections;
class Program
{
    static void Main()
    {
        ArrayList number = new ArrayList();

        for(int i = 0; i < 10; i++)
        {
            int randomNumber = new Random().Next(1, 51);
            number.Add(randomNumber);
        }
        Console.WriteLine(" Orginal Numbers:");

        foreach (int num in number)
        {
            Console.WriteLine(num + " ");
        }
       number.Sort();
        Console.WriteLine(" Sorted Numbers:");
        foreach (int num in number)
        {
            Console.WriteLine(num + " ");
        }
        int min = (int)number[0];
        int max = (int)number[number.Count - 1];
        int sum = 0;
        foreach(int num in number)
        {
            sum += num;
        }

        double average = (double)sum / number.Count;
        Console.Write("Averge of all numbers:");
        Console.WriteLine(average);

    }
}