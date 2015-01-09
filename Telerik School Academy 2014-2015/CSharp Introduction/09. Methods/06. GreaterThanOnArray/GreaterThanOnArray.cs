using System;
class GreaterThanOnArray
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numsToStr = input.Split(' ');
            int[] numbers = new int[numsToStr.Length];
            for (int i = 0; i < numsToStr.Length; i++)
            {
                numbers[i] = int.Parse(numsToStr[i]);
            }
            //..end input

            inspectElementEndPrintPosition(numbers);
        }

        public static void inspectElementEndPrintPosition(int[] arr){
		bool isBigger = false;
		
		for (int i = 1; i < arr.Length-1; i++) {
			if ((arr[i-1] < arr[i])&&(arr[i+1] < arr[i])) {
				Console.WriteLine("position: " + (i+1));
				isBigger = true;
				return;
			}
			
		}
		
		if (!isBigger) {
            Console.WriteLine("-1");
		}
	}
    }
