using System;
using System.Numerics;
class FibonaciNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonaci numbers");
            BigInteger firstNumber = 0;
            BigInteger secondNumber = 1;
            BigInteger result = firstNumber + secondNumber;
            BigInteger sumAll = firstNumber + secondNumber + result;
            for (int i = 3; i <= 100; i++)
            {
                firstNumber = secondNumber;
                secondNumber = result;
                result = firstNumber + secondNumber;
                sumAll += result;
            }

            Console.WriteLine("The sum is: " + sumAll);
        }
    }
