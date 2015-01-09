using System;
class GreaterThanProgram
    {
        static void Main()
        {
            Console.WriteLine("Enter your number of integers:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter number #{0}", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            int max = array[0];
            for (int k = 0; k < n; k++)
            {
                if (array[k] > max)
                {
                    max = array[k];
                }

            }


            int min = array[0];
            for (int j = 0; j < n; j++)
            {
                if (min > array[j])
                {
                    min = array[j];
                }

            }
            Console.WriteLine("The greater number is: " + max);
            Console.WriteLine("The smaller number is: " + min);
        }
    }
