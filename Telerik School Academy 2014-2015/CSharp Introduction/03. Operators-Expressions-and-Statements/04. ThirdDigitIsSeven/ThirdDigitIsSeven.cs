using System;
class ThirdDigitIsSeven
    {
        static void Main()
        {
            int number;
            bool result = true;

            do
            {
                Console.WriteLine("Enter your number: ");
                number = int.Parse(Console.ReadLine());
                int hunds = (number / 100) % 10;
                if (hunds == 7)
                {
                    result = true;
                    Console.Write("Third digit is 7? ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(result);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    result = false;
                    Console.Write("Third digit is 7? ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(result);
                    Console.ResetColor();
                    Console.WriteLine();
                }

            } while (number is int);
        }
    }
