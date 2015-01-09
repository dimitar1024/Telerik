using System;
class HexCode
    {
        static void Main()
        {
            int number = 254;
            string str = number.ToString("X");
            Console.WriteLine(str);

            Console.WriteLine("Enter number: ");
            int numbers = int.Parse(Console.ReadLine());
            string str1 = numbers.ToString("X");
            Console.WriteLine(str1);
        }
    }

