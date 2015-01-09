using System;
using System.Numerics;
class TrailingZeroesInN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            while (factorial % 10 == 0)
            {
                count++;
                factorial = factorial / 10;
            }

            Console.WriteLine(count);
        }
    }
