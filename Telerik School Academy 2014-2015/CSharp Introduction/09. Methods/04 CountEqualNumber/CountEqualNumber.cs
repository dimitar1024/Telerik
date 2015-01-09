using System;
class CountEqualNumber
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string[] numsToStr = input.Split(' ');
            int[] numbers = new int[numsToStr.Length];
            for (int i = 0; i < numsToStr.Length; i++)
            {
                numbers[i] = int.Parse(numsToStr[i]);
            }
            //..end input

            int[] sort = sortArr(numbers);
            getCountOfEqualNelenent(sort, n);
        }

        public static int[] sortArr(int[] numbers)
        {
            int[] sort = numbers;
            int min;

            for (int i = 0; i < sort.Length; i++)
            {
                min = i;
                for (int j = i + 1; j < sort.Length; j++)
                {
                    if (numbers[j] < numbers[min])
                    {
                        min = j;
                    }
                }
                int temp = numbers[i];
                numbers[i] = numbers[min];
                numbers[min] = temp;
            }
            return sort;
        }

        public static void getCountOfEqualNelenent(int[] arr, int n){
		int counter = 0;
		
		for (int i = 0; i < arr.Length; i++) {
			
			if (arr[i] == n) {
				counter++;
			}			
		}
		
		if (counter > 0) {
			Console.WriteLine("element[" + n + "] => "+ counter + " times");
		}
		else {
            Console.WriteLine("-1");
		}
		
	}
    }
