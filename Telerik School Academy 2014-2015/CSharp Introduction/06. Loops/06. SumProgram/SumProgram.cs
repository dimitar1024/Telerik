using System;
using System.Numerics;
class SumProgram
    {
        static void Main()
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X:");
            int x = int.Parse(Console.ReadLine());
            BigInteger xpow = 1;
            BigInteger factoriel = 1;
            BigInteger sum = 1;

            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
                xpow *= x;
                sum += (factoriel / xpow);
            }

            Console.WriteLine("The SUM is: " + sum);
        }
    }
