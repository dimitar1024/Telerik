using System;
class NumProgramMinusNumbDeviderOn3And7
{
    static void Main()
    {
        Console.WriteLine("Enter n number: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if ((i % 3 == 0) && (i % 7 == 0))
            {
                continue;
            }
            Console.Write(i + " ");
        }
    }
}
