using System;

class AgeCalculator
    {
        static void Main()
        {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            int afterTenYaer = age + 10;
            Console.WriteLine("Your age afrer 10 yaers is: {0} yaer", afterTenYaer);
        }
    }

