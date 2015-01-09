using System;
class MoreEqualElementsInArray
    {
        static void Main(string[] args)
        {
        String elements = Console.ReadLine();
		String[] numToStr = elements.Split(' ');
		
		int[] numbers = new int[numToStr.Length];
		for (int i = 0; i < numToStr.Length; i++) {
			numbers[i] = int.Parse(numToStr[i]);
		}
		
		int[] sort = sortArray(numbers);
		
		String exit = counterEqualElements(sort);
        Console.WriteLine(exit);
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

        public static String counterEqualElements(int[] arr)
        {
            int index = 0;
            int maxSequence = 0;
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                counter = 0;
                int j = i;

                while (arr[i] == arr[j])
                {
                    counter++;
                    j++;
                    if (j >= arr.Length)
                    {
                        break;
                    }
                }

                if (counter > maxSequence)
                {
                    maxSequence = counter;
                    index = i;
                }
            }

            String exit = ("" + arr[index] + "(" + maxSequence + " times)");
            return exit;

        }
    }
