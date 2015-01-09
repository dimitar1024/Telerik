using System;
class GreaterThanThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter three number for checking: ");
        Console.WriteLine("Enter first number: ");
        int fnumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int snumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        int tnumber = int.Parse(Console.ReadLine());
        int max = fnumber;
        if (snumber > max)
        {
            max = snumber;
        }
        if (tnumber > max)
        {
            max = tnumber;
        }
        Console.WriteLine("Greater number is: " + max);
    }
}
