using System;
class FactorielProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program for devided on two factoriels");
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K:");
            int k = int.Parse(Console.ReadLine());
            decimal factorielN = 1;
            decimal factorielK = 1;
            decimal result;
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

                result = factorielN / factorielK;
                Console.WriteLine("N!/K! = " + result);
            }
            else
            {
                Console.WriteLine("ERROR! Pleace new numbers");
            }
        }
    }
