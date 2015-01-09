using System;
using System.Collections.Generic;
using System.Text;



class QuickSort
    {



        static public int Devide(int[] numbers, int left, int right)
        {

            int pivot = numbers[left];

            while (true)
            {

                while (numbers[left] < pivot)

                    left++;



                while (numbers[right] > pivot)

                    right--;



                if (left < right)
                {

                    int temp = numbers[right];

                    numbers[right] = numbers[left];

                    numbers[left] = temp;

                }

                else
                {

                    return right;

                }

            }

        }



        static public void Quick_Sort(int[] arr, int left, int right)
        {

            
            if (left < right)
            {

                int pivot = Devide(arr, left, right);



                if (pivot > 1)

                    Quick_Sort(arr, left, pivot - 1);



                if (pivot + 1 < right)

                    Quick_Sort(arr, pivot + 1, right);

            }

        }



        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of your integers");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }



            Console.WriteLine("QuickSort: ");

            Quick_Sort(numbers, 0, n - 1);

            for (int i = 0; i < n; i++)

                Console.WriteLine(numbers[i]);



            Console.WriteLine();



        }

    }



