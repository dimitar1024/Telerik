using System;
class BinarySearch
{
    static void Main()
    {
        String input = Console.ReadLine();
        String[] nums = input.Split(' ');
        int[] numbers = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int[] sort = sortArray(numbers);

        int find = int.Parse(Console.ReadLine());
        BinarySearch(find, sort);


    }
    public static int[] sortArray(int[] arr)
    {
        int min;
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            min = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }
            int temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }

        return arr;
    }

    public static void BinarySearch(int find, int[] arr)
    {
        int startIndex = 0;
        int endIndex = arr.Length - 1;
        int indexNow = 0;

        indexNow = (startIndex + endIndex) / 2;

        do
        {
            if (arr[indexNow] == find)
            {
                Console.WriteLine(indexNow);
                return;
            }
            else if (arr[indexNow] > find)
            {
                endIndex = indexNow;
                indexNow = (startIndex + endIndex) / 2;
            }
            else
            {
                startIndex = indexNow;
                indexNow = (startIndex + endIndex) / 2;
            }
        } while (startIndex != endIndex);

        Console.WriteLine("Not Found!");
    }

}
