using System;
class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int numNow = 0;

        if (n <= 20)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    numNow = col + row;
                    Console.Write("{0,-3}", numNow);
                }
                Console.WriteLine();
            }

        }
    }
}
