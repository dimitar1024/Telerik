using System;
class LeksikalCheck
{
    static void Main()
    {
        String first = Console.ReadLine();
		String two = Console.ReadLine();
		
		char[] firstToChar= first.ToCharArray();
		char[] twoToChar= two.ToCharArray();
		int i = 0;
		int j = 0;
		bool isEqual= false;
		
		while (i < firstToChar.Length && j < twoToChar.Length ) {
			if (firstToChar[i] > twoToChar[j]) {
				Console.WriteLine(two);
				isEqual = false;
				break;
			}
			else if (firstToChar[i] < twoToChar[j]) {
				Console.WriteLine(first);
				isEqual = false;
				break;
			}
			else {
				isEqual = true;
			}
			
			i++;
			j++;
		}
		
		if (isEqual == true) {
			if (firstToChar.Length < twoToChar.Length) {
				Console.WriteLine(first);
			}
			else if(firstToChar.Length > twoToChar.Length ) {
				Console.WriteLine(two);
			}
			else {
                Console.WriteLine("No difference");
			}
		}
    }
}
