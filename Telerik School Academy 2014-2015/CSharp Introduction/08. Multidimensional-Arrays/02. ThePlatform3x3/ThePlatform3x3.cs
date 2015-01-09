using System;
class ThePlatform3x3
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] rowToStr = input.Split(' ');
            int[] rowNums = new int[rowToStr.Length];
            for (int j = 0; j < rowToStr.Length; j++)
            {
                rowNums[j] = int.Parse(rowToStr[j]);
            }
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = rowNums[j];
            }
        }

        //program

        int theBestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > theBestSum)
                {
                    theBestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        //print on console
        Console.WriteLine("The best platform is:");
        Console.WriteLine("{0}  {1}  {2}", matrix[bestRow, bestCol],
                matrix[bestRow, bestCol + 1],
                matrix[bestRow, bestCol + 2]);
        Console.WriteLine("{0}  {1}  {2}", matrix[bestRow + 1, bestCol],
                matrix[bestRow + 1, bestCol + 1],
                matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine("{0}  {1}  {2}", matrix[bestRow + 2, bestCol],
                matrix[bestRow + 2, bestCol + 1],
                matrix[bestRow + 2, bestCol + 2]);
        Console.WriteLine("The maximal sum is: {0}", theBestSum);
    }
}
