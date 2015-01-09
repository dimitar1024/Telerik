using System;
class ModifyABitAtGivenPosition
{
    static void Main()
    {
        int number, p, v, result, mask;

        Console.WriteLine("Enter number: ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position:");
        p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value:");
        v = int.Parse(Console.ReadLine());

        if (v == 1)
        {
            mask = 1 << p;
            result = number | mask;
            Console.WriteLine("The new number is: " + result);
        }
        if (v == 0)
        {
            mask = ~(1 << p);
            result = number & mask;
            Console.WriteLine("The new number is: " + result);
        }
    }
}
