using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May_12th
{
    abstract class  shape
    {
        public abstract void Draw();
        public void Display()
        {
            Console.WriteLine("Displaying shape");
        }
    }
    class Cricle :shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
    class Rectangle : shape 
    { 
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }

}


using May_12th;

class Program
{
    static void Main()
    {
        Cricle cricle = new Cricle();
        Rectangle rectangle = new Rectangle();
        cricle.Draw();
        rectangle.Draw();
    }
}

