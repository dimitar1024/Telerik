using System;
class PointInACircleAndOutOfARectangle
    {
        static void Main()
        {
            Console.WriteLine("Enter X: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y: ");
            double y = double.Parse(Console.ReadLine());
            double radius = Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1));

            if (((x >= -1) && (x <= 6)) && ((y >= -1) && (y <= 1)))
            {
                Console.WriteLine("No");
            }
            else
            {
                bool result = (radius <= 1.5);
                if (result == true)
                {
                    Console.Write("The point is inside K & outside of R? ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Yes");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("The point is inside K & outside of R? ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }
    }
