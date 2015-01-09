using System;
using System.Collections.Generic;
class MergeSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int leftLength = n / 2;         
        int rightLength = n - leftLength;         
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        for (int i = 0; i < n; i++)
        {
           arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < leftLength; i++)
        {
            left.Add(arr[i]);
        }
        for (int j = leftLength; j < n; j++)
        {
            right.Add(arr[j]);
        }
        left.Sort();
        right.Sort();
        int m = 0;
        int l = 0;
        for (int k = 0; k < n; k++)
        {
            if ((m < leftLength) && (l < rightLength))
            {
                if (left[m] <= right[l])
                {
                    arr[k] = left[m];
                    m++;
                }
                else if (right[l] < left[m])
                {
                    arr[k] = right[l];
                    l++;
                }
            }
            else if (m >= leftLength)
            {
                while (l <= rightLength)
                {
                    arr[k] = right[l - 1];
                    l++;
                }
            }
            else if (l >= rightLength)
            {
                while (m < leftLength)
                {
                    arr[k] = left[m];
                    m++;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i]);
            if (i != n - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

