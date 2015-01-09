using System;

namespace PrintMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = DoMatrixA(n);
            PrintMatrix(matrix);

            Console.WriteLine();

            matrix = DoMatrixB(n);
            PrintMatrix(matrix);

            Console.WriteLine();

            matrix = DoMatrixC(n);
            PrintMatrix(matrix);

            Console.WriteLine();

            matrix = DoMatrixD(n);
            PrintMatrix(matrix);

            Console.WriteLine();
        }

        static int[,] DoMatrixA(int n)
        {
            int[,] matrix = new int[n, n];

            matrix[0, 0] = 1;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                matrix[0, i] = matrix[0, i - 1] + n;
            }

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix[i - 1, j] + 1;
                }
            }

            return matrix;
        }

        static int[,] DoMatrixB(int n)
        {
            int[,] matrix = new int[n, n];
            matrix[0, 0] = 1;

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                if (i % 2 == 1)
                {
                    matrix[0, i] = matrix[0, i - 1] + n * 2 - 1;
                }
                else
                {
                    matrix[0, i] = matrix[0, i - 1] + 1;
                }
            }

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j % 2 == 1)
                    {
                        matrix[i, j] = matrix[i - 1, j] - 1;
                    }
                    else
                    {
                        matrix[i, j] = matrix[i - 1, j] + 1;
                    }
                }
            }

            return matrix;
        }

        static int[,] DoMatrixC(int n)
        {
            int[,] matrix = new int[n, n];
            matrix[n - 1, 0] = 1;
            int counter = 1;
            for (int row = n - 2; row >= 0; row--)
            {
                matrix[row, 0] = matrix[row + 1, 0] + counter;
                int newRow = row;
                for (int diagonal = 1; diagonal <= counter; diagonal++)
                {
                    matrix[newRow + 1, diagonal] = matrix[newRow, diagonal - 1] + 1;
                    newRow++;
                }
                counter++;
            }

            matrix[0, n - 1] = n * n;
            int diagonalLength = 2;
            int posX = 1;
            int posY = n - 1;
            int prevX = 0;
            int prevY = n - 1;

            for (int i = 1; i < counter - 1; i++)
            {
                for (int j = 1; j <= diagonalLength; j++)
                {
                    matrix[posX, posY] = matrix[prevX, prevY] - 1;
                    prevX = posX;
                    prevY = posY;
                    posX--;
                    posY--;
                }
                diagonalLength++;
                posX = i + 1;
                posY = n - 1;
            }

            return matrix;
        }

        static int[,] DoMatrixD(int n)
        {
            int[,] matrix = new int[n, n];
            int numConcentricSquares = (int)Math.Ceiling((n) / 2.0);
            int j;
            int sideLen = n;
            int currNum = 0;

            for (int i = 0; i < numConcentricSquares; i++)
            {

                // left
                for (j = 0; j < sideLen; j++)
                {
                    matrix[i + j, i] = ++currNum;
                }

                // bottom
                for (j = 1; j < sideLen - 1; j++)
                {
                    matrix[n - 1 - i, i + j] = ++currNum;
                }

                // right
                for (j = sideLen - 1; j > 0; j--)
                {
                    matrix[i + j, n - 1 - i] = ++currNum;
                }

                // top
                for (j = sideLen - 1; j > 0; j--)
                {
                    matrix[i, i + j] = ++currNum;
                }

                sideLen -= 2;
            }

            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

