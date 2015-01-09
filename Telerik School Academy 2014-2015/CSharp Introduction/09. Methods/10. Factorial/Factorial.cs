using System;
class Factorial
    {
        static void Main()
        {
        int number = int.Parse(Console.ReadLine());
		
		
		if (number>0 && number<100) {
			factorial(number);
		}
		else {
            Console.WriteLine("Error");
		}

	}

        public static void factorial(int number){
		
		long factorielN = 1;
		do
        {
            factorielN *= number;
            number--;
        } while (number > 0);

        Console.WriteLine(factorielN);
	}
    }
