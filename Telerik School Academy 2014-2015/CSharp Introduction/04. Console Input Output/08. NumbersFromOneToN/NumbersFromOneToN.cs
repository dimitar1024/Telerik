using System;
class NumbersFromOneToN
    {
        static void Main()
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Numbers...");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + 1);

            }
        }
    }
