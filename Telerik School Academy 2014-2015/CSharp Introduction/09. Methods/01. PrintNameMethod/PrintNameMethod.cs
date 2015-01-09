using System;
class PrintNameMethod
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            printGreating(name);
        }

    public static void printGreating(string name){
        Console.WriteLine("Hello, " + name + "!");
	}
    }
