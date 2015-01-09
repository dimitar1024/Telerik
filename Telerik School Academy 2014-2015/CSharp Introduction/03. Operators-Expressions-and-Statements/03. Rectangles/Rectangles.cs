using System;
class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Enter \"a\" on your rectangles: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"b\" on your rectangles: ");
            double b = double.Parse(Console.ReadLine());
            double s = a * b;
            double p = (a + b) * 2;
            Console.WriteLine("Area\'s on your rectangles is: " + s + " sm");
            Console.WriteLine("Perimetar on your rectangles is: " + p + " sm");
        }
    }
