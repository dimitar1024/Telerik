using System;
class SequenceOfEqualElements
    {
        static void Main()
        {
            String systemIn = Console.ReadLine();
		String[] numStr = systemIn.Split(',');
		int[] numbers = new int[numStr.Length];
		
		for (int i = 0; i < numStr.Length; i++) {
			numStr[i] = numStr[i].Trim();
			numbers[i] = int.Parse(numStr[i]);
			
		}
		int index =0;
		int maxSequence=0;
		int counter = 0;
		
		for (int i = 0; i < numbers.Length; i++) {
			counter = 0;
			int j = i;
			
			while (numbers[i] == numbers[j]) {
				counter++;
				j++;
				if (j >=numbers.Length) {
					break;
				}
			}
			
			if (counter > maxSequence) {
				maxSequence = counter;
				index = i;
			}
		}
		//print on Console
		for (int j = index; j < index + maxSequence; j++) {
			if (j == index+maxSequence-1) {
				Console.WriteLine(numbers[j]);
			}
			else {
                Console.WriteLine(numbers[j] + ", ");
			}
		}
        }
    }
