using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using May_12th;

namespace May_12th
{
    interface Ishape
    {
        void Draw();
    }
    class Circle : Ishape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle();

        circle.Draw();
    }
}
