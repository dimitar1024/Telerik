using System;
class SumOfThreeNumbers
{
    static void Main()
    {
        double sum = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter #{0}", i + 1);
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine(sum);
    }
}
