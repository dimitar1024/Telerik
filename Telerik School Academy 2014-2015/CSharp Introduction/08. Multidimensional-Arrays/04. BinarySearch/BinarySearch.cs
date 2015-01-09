using System;

class BinarySearch
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numToStr = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] arr = new int[numToStr.Length];
            for (int i = 0; i < numToStr.Length; i++)
            {
                arr[i] = int.Parse(numToStr[i]);
            }
            Array.Sort(arr);
            int number = int.Parse(Console.ReadLine());

            BinarySearchInArray(number, arr);

        }

        static void BinarySearchInArray(int numberToFind, int[] array)
        {
            int startIndex = 0;
            int endIndex = array.Length - 1;
            int current = 0;

            current = (startIndex + endIndex) / 2;
            do
            {

                if (array[current] == numberToFind)
                {
                    Console.WriteLine("{0}", current);
                    return;
                }
                else if (array[current] > numberToFind)
                {
                    endIndex = current;
                    current = (startIndex + endIndex - 1) / 2;
                }
                else
                {
                    startIndex = current;
                    current = (startIndex + endIndex + 1) / 2;
                }

            } while (startIndex != endIndex);

            Console.WriteLine("Not found");
        }
    }
