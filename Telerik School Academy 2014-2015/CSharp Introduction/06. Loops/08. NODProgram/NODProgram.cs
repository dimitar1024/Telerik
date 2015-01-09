using System;
class NODProgram
    {
        static void Main()
        {
            Console.WriteLine("Enter first  number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            int minValue = Math.Min(Math.Abs(a), Math.Abs(b));

            for (int i = minValue; i >= 0; i--)
            {
                if ((a % i == 0) && (b % i == 0))
                {
                    Console.WriteLine("NOD is: " + i);
                    break;
                }

            }
        }
    }
