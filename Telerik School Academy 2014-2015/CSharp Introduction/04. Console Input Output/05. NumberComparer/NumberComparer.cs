using System;
class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            double b = double.Parse(Console.ReadLine());
            double greater = (a + b + Math.Abs(a - b)) / 2;
            Console.WriteLine("The graeter is: {0}", greater);
        }
    }
