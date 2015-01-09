using System;
class DivideBySevenAndFive
    {
        static void Main()
        {
            int number;
            bool result = true;

            do
            {
                Console.WriteLine("Enter number: ");
                number = int.Parse(Console.ReadLine());
                if ((number % 5 == 0) && (number % 7 == 0))
                {
                    result = true;
                    Console.Write("Is the number odd? ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(result);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    result = false;
                    Console.Write("Is the number odd? ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(result);
                    Console.ResetColor();
                    Console.WriteLine();
                }
            } while (number is int);

        }
    }
