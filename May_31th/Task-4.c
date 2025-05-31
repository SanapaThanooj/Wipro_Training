using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Task_4
    {

        static int totalLines = 0;
        static object lockObj = new object();

        static void CountLines(string filePath)
        {
            try
            {

                int count = File.ReadAllLines(filePath).Length;


                lock (lockObj)
                {
                    totalLines += count;
                }

                Console.WriteLine($"{filePath}: {count} lines");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading {filePath}: {ex.Message}");
            }
        }

        static void Main()
        {

            string[] files = { "file1.txt", "file2.txt", "file3.txt" };

            Thread[] threads = new Thread[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                string path = files[i]; 
                threads[i] = new Thread(() => CountLines(path));
                threads[i].Start();
            }


            foreach (var t in threads)
            {
                t.Join();
            }

            Console.WriteLine($"\nTotal lines across all files: {totalLines}");
        }
    }
}

