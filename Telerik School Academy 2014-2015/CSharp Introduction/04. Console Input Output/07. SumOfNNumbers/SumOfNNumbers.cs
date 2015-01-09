using System;
class SumOfNNumbers
{
    static void Main()
    {
        double sum = 0;
        Console.WriteLine("Enter number of integers:");
        int numbers = int.Parse(Console.ReadLine());
        for (int i = 0; i < numbers; i++)
        {
            Console.WriteLine("Enter number #{0}", i + 1);
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum is:");
        Console.WriteLine(sum);
    }
}
