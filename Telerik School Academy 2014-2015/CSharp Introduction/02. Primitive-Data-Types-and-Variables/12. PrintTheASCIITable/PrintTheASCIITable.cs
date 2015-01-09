using System;

class PrintTheASCIITable
    {
        static void Main()
        {
            for (int i = 0; i <= 255; i++)
            {
                char sym = (char)i;
                Console.WriteLine("The symbol in position {0} is:  {1}", i, sym);
            }
        }
    }

