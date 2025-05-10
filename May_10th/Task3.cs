using System;

class AreaCalculator
{
    public static double Area(double length, double breadth)
    {
        return length * breadth;
    }

    public static double Area(double radius)
    {
        return Math.PI * radius * radius;
    }

    public static double Area(double baseLength, double height, string shape)
    {
        if (shape.ToLower() == "triangle")
        {
            return 0.5 * baseLength * height;
        }
        else
        {
            return baseLength * height;
        }
    }

    static void Main()
    {
        double rectangle = Area(5, 4);
        Console.WriteLine("Rectangle Area: " + rectangle);

        double circle = Area(3);
        Console.WriteLine("Circle Area: " + circle);

        double triangle = Area(6, 3, "triangle");
        Console.WriteLine("Triangle Area: " + triangle);
    }
}