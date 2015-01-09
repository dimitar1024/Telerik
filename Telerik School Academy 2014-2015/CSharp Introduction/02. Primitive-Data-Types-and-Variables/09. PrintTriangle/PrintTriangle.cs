using System;
class Program
    {
        static void Main()
        {
            char symbol = '\u00a9';
            string interval = " ";

            Console.WriteLine("{0}{0}{0}{1}", interval, symbol);
            Console.WriteLine("{0}{0}{1}{0}{1}", interval, symbol);
            Console.WriteLine("{0}{1}{0}{0}{0}{1}", interval, symbol);
            Console.WriteLine("{1}{0}{1}{0}{1}{0}{1}", interval, symbol);
        }
    }

