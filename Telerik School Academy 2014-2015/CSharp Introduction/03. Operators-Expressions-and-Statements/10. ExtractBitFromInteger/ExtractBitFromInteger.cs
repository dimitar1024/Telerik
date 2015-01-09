using System;
class ExtractBitFromInteger
{
    static void Main()
    {
        int number, p;
        Console.WriteLine("Enter number: ");
        number = int.Parse(Console.ReadLine());
        p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int bit;
        int result;
        bit = number & mask;
        result = bit >> p;
        Console.WriteLine("The bit on position {0} in your number {1} is {2}", p, number, result);
    }
}