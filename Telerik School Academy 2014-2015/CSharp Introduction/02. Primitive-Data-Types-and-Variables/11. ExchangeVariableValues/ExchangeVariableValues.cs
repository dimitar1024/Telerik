using System;

class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int rotation;

            rotation = b;
            b = a;
            a = rotation;

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
        }
    }

