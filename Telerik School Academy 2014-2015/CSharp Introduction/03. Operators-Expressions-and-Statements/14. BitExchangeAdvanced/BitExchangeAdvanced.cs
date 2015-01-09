using System;
class BitExchangeAdvanced
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter p: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter q: ");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        int subQ = q - p;
        int subK = p + k;
        for (int i = p; i < subK; i++)
        {
            uint firstMask = (uint)1 << i;
            uint firstResult = number & firstMask;
            firstResult >>= i;
            uint secondMask = (uint)1 << (subQ + i);
            uint secondResult = number & secondMask;
            secondResult >>= (subQ + i);
            if (secondResult == 1)
            {
                number |= firstMask;
            }
            else
            {
                number &= (~firstMask);
            }
            if (firstResult == 1)
            {
                number |= secondMask;
            }
            else
            {
                number &= (~secondMask);
            }

        }
        Console.WriteLine("After exchange");
        Console.WriteLine(number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
