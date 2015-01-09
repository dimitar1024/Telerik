using System;
class SequenceWithMaxSumOfElements
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int sumNow = 0;
        int index = 0;
        int maxSum = 0;
        int countElements = 1;

        for (int i = 0; i <= n - k; i++)
        {
            int j = i;
            for (; j < i + k; j++)
            {
                sumNow += numbers[j];
            }
            if (sumNow > maxSum)
            {
                maxSum = sumNow;
                index = i;
                countElements = j - i;
            }
            sumNow = 0;
        }

        for (int i = index; i < index + countElements; i++)
        {
            Console.WriteLine(numbers[i] + " ");
        }
    }
}
