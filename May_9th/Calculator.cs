using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace may_7
{
     class Calculator
    {
          public int add(int a, int b)
        {
            return a + b;
        }
        public double add(double a, double b)
        {
            return a + b;
        }
        public int add(int a, int b, int c)
        {
            return a * b * c;
        }
        public int multiply(int a, int b)
        {
            return a * b;
        }
        public double multiply(double a, double b)
        {
            return a * b;
        }
        public int multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        public int subtract(int a, int b)
        {
            return a - b;
        }
        public double subtract(double a,double b)
        {
            return a - b;
        }
        public int subtract(int a, int b, int c)
        {
            return a - b - c;
        }
    }
}

//using may_7;
namespace may_7
{
    class Program
    {
        static void Main()
        {

            Calculator calcultor = new Calculator ();

            Console.WriteLine("Addition :");
            Console.WriteLine("a + b = " + calcultor.add(1, 2));
            Console.WriteLine("a + b = " + calcultor.add(0.9, 3.9));
            Console.WriteLine("a + b  + c = " + calcultor.add(1, 2, 3));

            Console.WriteLine("Multiplication :");
            Console.WriteLine("a * b = " + calcultor.multiply(1, 2));
            Console.WriteLine("a * b = " + calcultor.multiply(0.9, 3.9));
            Console.WriteLine("a * b * c = " + calcultor.multiply(1, 2, 3));

            Console.WriteLine("Subtraction :");
            Console.WriteLine("a - b = " + calcultor.subtract(1, 2));
            Console.WriteLine("a - b = " + calcultor.subtract(0.9, 3.9));
            Console.WriteLine("a - b - c = " + calcultor.subtract(1, 2, 3));

        }
    }
}
