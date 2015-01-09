using System;
class CompareThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter c:");
        int c = int.Parse(Console.ReadLine());

        if ((a > b) && (a > c))
        {
            if (b > c)
            {
                Console.WriteLine(a + " > " + b + " > " + c);
            }
            else
            {
                Console.WriteLine(a + " > " + c + " > " + b);
            }
        }
        else if ((b > a) && (b > c))
        {
            if (a > c)
            {
                Console.WriteLine(b + " > " + a + " > " + c);
            }
            else
            {
                Console.WriteLine(b + " > " + c + " > " + a);
            }
        }

        else if ((c > a) && (c > b))
        {
            if (a > b)
            {
                Console.WriteLine(c + " > " + a + " > " + b);
            }
            else
            {
                Console.WriteLine(c + " > " + b + " > " + a);
            }
        }
    }
}
