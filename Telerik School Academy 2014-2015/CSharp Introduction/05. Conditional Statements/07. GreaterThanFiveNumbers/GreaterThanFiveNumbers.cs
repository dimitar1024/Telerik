using System;
class GreaterThanFiveNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter five numbers: ");
            Console.WriteLine("Enter first number: ");
            int fnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int snumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int tnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fourth number: ");
            int fonumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fifth number: ");
            int finumber = int.Parse(Console.ReadLine());
            int max = fnumber;
            if (snumber > max)
            {
                max = snumber;
            }
            if (tnumber > max)
            {
                max = tnumber;
            }
            if (fonumber > max)
            {
                max = fonumber;
            }
            if (finumber > max)
            {
                max = finumber;
            }
            Console.WriteLine("The greater number is: " + max);
        }
    }
