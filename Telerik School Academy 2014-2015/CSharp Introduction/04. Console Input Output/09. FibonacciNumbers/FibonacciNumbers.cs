using System;
class FibonacciNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter n:");
            int n = 100;
            ulong firstNumber = 0;
            ulong secondNumber = 1;
            ulong nextNumber = firstNumber + secondNumber;
            if (n == 1)
            {
                Console.WriteLine(firstNumber);
            }
            if (n == 2)
            {
                Console.WriteLine(firstNumber);
                Console.WriteLine(secondNumber);
            }
            if (n >= 3)
            {


                Console.WriteLine(firstNumber);
                Console.WriteLine(secondNumber);
                Console.WriteLine(nextNumber);
                for (int i = 3; i < n; i++)
                {

                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                    nextNumber = firstNumber + secondNumber;
                    Console.WriteLine(nextNumber);
                }
            }
        }
    }
