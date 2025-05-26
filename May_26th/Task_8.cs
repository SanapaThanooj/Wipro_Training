using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ImageProcessor
{
    public static async Task Main()
    {
        List<string> images = new List<string>();
        for (int i = 1; i <= 20; i++)
        {
            images.Add($"Image{i}.jpg");
        }

        int completed = 0;
        object lockObj = new object();

        await Parallel.ForEachAsync(images, async (image, token) =>
        {
            await Task.Delay(200); // Simulate processing
            lock (lockObj)
            {
                completed++;
                int percent = completed * 100 / images.Count;
                Console.WriteLine($"Processed {image} - {percent}% complete");
            }
        });

        Console.WriteLine("All images processed.");
    }
}