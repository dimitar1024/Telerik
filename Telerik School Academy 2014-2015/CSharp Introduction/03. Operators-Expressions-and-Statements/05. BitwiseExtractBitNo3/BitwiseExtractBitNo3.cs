using System;
class BitwiseExtractBitNo3
{
    static void Main()
    {
        int number;
        do
        {
            Console.WriteLine("Enter the number:");
            number = int.Parse(Console.ReadLine());
            int mask = 1 << 3;
            int bit;
            int result;
            bit = number & mask;
            result = bit >> 3;
            Console.WriteLine("The bit is: " + result);
        } while (number is int);
    }
}
