using System;
class OddOrEvenIntegers
    {
        static void Main()
        {
            int number;
            do
            {
                bool odd = true;
                Console.WriteLine("Enter your number: ");
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    odd = false;
                    Console.Write("Is the number odd? ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(odd);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    odd = true;
                    Console.Write("Is the number odd? ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(odd);
                    Console.ResetColor();
                    Console.WriteLine();
                }

            } while (number is int);
        }
    }

