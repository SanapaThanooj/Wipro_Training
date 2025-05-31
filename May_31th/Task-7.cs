using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
     class Calculator
    {
        public static int Add(int a,int b) => a + b;
        public static float Add(float a, float b) => a + b;
        public static double Add(double a, double b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static float Subtract(float a, float b) => a - b;
        public static double Subtract(double a, double b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public static float Multiply(float a, float b) => a * b;
        public static double Multiply(double a, double b) => a * b;

        static void Main()
        {
            Console.WriteLine("Enter first Number:");
            var input1 = Console.ReadLine();
            Console.WriteLine("Enter second Number:");
            var input2 = Console.ReadLine();

            if(int.TryParse(input1, out int int1) && int.TryParse(input2, out int int2))
            {
                Console.WriteLine($"Addition: {Add(int1, int2)}");
                Console.WriteLine($"Subtraction: {Subtract(int1, int2)}");
                Console.WriteLine($"Multiplication: {Multiply(int1, int2)}");

            }
            else if (float.TryParse(input1, out float float1) && float.TryParse(input2, out float float2))
            {
                Console.WriteLine($"Addition: {Add(float1, float2)}");
                Console.WriteLine($"Subtraction: {Subtract(float1, float2)}");
                Console.WriteLine($"Multiplication: {Multiply(float1, float2)}");

            }
            else if (double.TryParse(input1, out double double1) && double.TryParse(input2, out double double2))
            {
                Console.WriteLine($"Addition: {Add(double1, double2)}");
                Console.WriteLine($"Subtraction: {Subtract(double1, double2)}");
                Console.WriteLine($"Multiplication: {Multiply(double1, double2)}");

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }
        }
    }
}
