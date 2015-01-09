﻿using System;
using System.Collections.Generic;

namespace FindTheLongestSubsequeanceOfEqualElements
{
    class SequencesInTheMatrix
    {
        static string[,] matrix;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            // In Java I will use HeshMap. It is alternative on Dictionary in C#;
            matrix = new string[n, m];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] transformation = input.Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = transformation[j];
                }

            }

            Dictionary<string, int> sequence = new Dictionary<string, int>();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int neighbourCount = LookupNeighbours(row, col);
                    if (neighbourCount == 0)
                    {
                        if (sequence.ContainsKey(matrix[row, col]))
                        {
                            sequence.Remove(matrix[row, col]);
                        }
                    }
                    else
                    {
                        if (sequence.ContainsKey(matrix[row, col]))
                        {
                            sequence[matrix[row, col]]++;
                        }
                        else
                        {
                            sequence.Add(matrix[row, col], 1);
                        }
                    }
                }
            }

            var sortedDict = (from entry in sequence orderby entry.Value ascending select entry).ToDictionary(pair => pair.Key, pair => pair.Value);
            KeyValuePair<string, int> element;
            int index = sortedDict.Count - 1;
            element = sortedDict.ElementAt(index);

            int repeats = element.Value;
            string str = element.Key;

            string result = "";
            for (int i = 1; i <= repeats; i++)
            {
                result += " ";
                result += str;
            }

            Console.WriteLine(result);

        }

        private static int LookupNeighbours(int x, int y)
        {
            int result = 0;
            for (int row = x - 1; row <= x + 1; row++)
            {
                if (row < 0 || row > matrix.GetLength(0) - 1)
                {
                    continue;
                }
                for (int col = y - 1; col <= y + 1; col++)
                {
                    if (col < 0 || col > matrix.GetLength(1) - 1 || (row == x && col == y))
                    {
                        continue;
                    }
                    if (matrix[row, col] == matrix[x, y])
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
