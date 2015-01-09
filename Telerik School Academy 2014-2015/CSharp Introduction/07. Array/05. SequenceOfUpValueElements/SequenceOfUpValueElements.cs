using System;
class SequenceOfUpValueElements
    {
        static void Main()
        {
            String input = Console.ReadLine();
		
		String[] numStr = input.Split(',');
		
		int[] numbers = new int[numStr.Length];
		
		for (int i = 0; i < numbers.Length; i++) {
			numStr[i] = numStr[i].Trim();
			numbers[i] = int.Parse(numStr[i]);
		}
		
		int counter = 0;
		int maxSequence = 0;
		int index = 0;
		
		for (int i = 0; i < numbers.Length-1; i++) {
			counter = 0;
			int j = i+1;
			int k = i;
			
			while (numbers[k]<numbers[j]) {
				counter++;
				j++;
				k++;
				if (j >= numbers.Length) {
					break;
				}
			}
			if (counter > maxSequence) {
				maxSequence = counter;
				index = i;
			}
			
		}
		
		for (int i = index; i <= index+maxSequence ; i++) {
            Console.WriteLine(numbers[i] + " ");
		}
        }
    }
