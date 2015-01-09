using System;
using System.Numerics;
class FactorielProgramTwo
    {
        static void Main()
        {
            Console.WriteLine("Faktoriel program (N!*K!)/(N-K)!");
            Console.WriteLine("Enter N: ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("Enter K: ");
            BigInteger k = BigInteger.Parse(Console.ReadLine());
            BigInteger factorielN = 1;
            BigInteger factorielK = 1;
            BigInteger nMinusK = n - k;
            BigInteger factorielNminusK = 1;
            BigInteger result;
            if (k < n)
            {
                do
                {
                    factorielN *= n;
                    n--;
                } while (n > 0);
                do
                {
                    factorielK *= k;
                    k--;
                } while (k > 0);
                do
                {
                    factorielNminusK *= nMinusK;
                    nMinusK--;
                } while (nMinusK > 0);
                result = (factorielN * factorielK) / factorielNminusK;
                Console.WriteLine("N!*K!/(N-K)! = " + result);
            }

            else
            {
                Console.WriteLine("ERROR! Pleace new numbers");
            }

        }
    }
