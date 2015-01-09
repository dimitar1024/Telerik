using System;
class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("Enter \"a\" on your trapezoids");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"b\" on your trapezoids");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"h\" on your trapezoids");
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * h;
            Console.WriteLine("Area is: " + area);
        }
    }
