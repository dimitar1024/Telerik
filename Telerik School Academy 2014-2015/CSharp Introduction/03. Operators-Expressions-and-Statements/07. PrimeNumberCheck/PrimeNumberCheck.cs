using System;
class PrimeNumberCheck
    {
        static void Main()
    {
        int number;
        bool result;

            Console.WriteLine("Enter number:");
            number = int.Parse(Console.ReadLine());
            if (number > 0 && number < 100)
            {
                if ((number % 2 != 0) && (number % 3 != 0) && (number % 5 != 0) && (number % 7 != 0) || (number == 1) || (number == 2) || (number == 3) || (number == 5) || (number == 7))
                {
                    result = true;
                    Console.Write("The number is prime? ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(result);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    result = false;
                    Console.Write("The number is prime? ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(result);
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }
    }
