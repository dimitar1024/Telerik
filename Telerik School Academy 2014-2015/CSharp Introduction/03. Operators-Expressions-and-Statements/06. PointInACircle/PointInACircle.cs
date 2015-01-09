using System;
class PointInACircle
{
    static void Main()
    {
        double x, y, sqrt;
        bool result;

        Console.WriteLine("Enter X: ");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y: ");
        y = double.Parse(Console.ReadLine());
        result = true;
        sqrt = Math.Sqrt(x * x + y * y);
        if (sqrt <= 2)
        {
            result = true;
            Console.Write("The point is inside of circle? ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(result);
            Console.ResetColor();
            Console.WriteLine();
        }
        else
        {
            result = false;
            Console.Write("The point is inside of circle? ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(result);
            Console.ResetColor();
            Console.WriteLine();

        }
    }
}
