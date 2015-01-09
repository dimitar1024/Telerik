using System;
class CheckABitAtGivenPosition
{
    static void Main(string[] args)
    {
        int number, p;
        bool exit;

        Console.WriteLine("Enter number: ");
        number = int.Parse(Console.ReadLine());
        p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int bit;
        int result;
        bit = number & mask;
        result = bit >> p;
        if (result == 1)
        {
            exit = true;
            Console.Write("bit on position {0} is 1? ", p);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(exit);
            Console.ResetColor();
            Console.WriteLine();
        }
        else
        {
            exit = false;
            Console.Write("bit on position {0} is 1? ", p);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(exit);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
