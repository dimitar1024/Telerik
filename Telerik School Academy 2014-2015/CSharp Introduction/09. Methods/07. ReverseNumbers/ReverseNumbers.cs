using System;
class ReverseNumbers
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            
            reverseNumbers(number);
        }

        public static void reverseNumbers(int number){
		string newNum = "";
		while (number>0) {
			int digit = number%10;
			number = number/10;
			newNum = newNum + digit;
		}

        Console.WriteLine(newNum);
	}
    }
