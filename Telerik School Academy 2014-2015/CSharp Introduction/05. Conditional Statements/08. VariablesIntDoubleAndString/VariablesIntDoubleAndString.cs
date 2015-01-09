using System;
class VariablesIntDoubleAndString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your type: 0 -> int; 1 -> double; 2 -> string");
        int number = int.Parse(Console.ReadLine());
        switch (number)
        {
            case 0:
                Console.WriteLine("Enter your int number:");
                int n = int.Parse(Console.ReadLine());
                n += 1;
                Console.WriteLine("The number is: " + n);
                break;
            case 1:
                Console.WriteLine("Enter your double number:");
                double dnumber = double.Parse(Console.ReadLine());
                dnumber += 1.0;
                Console.WriteLine("The number is: " + dnumber);
                break;

            case 2:
                Console.WriteLine("Enter your string");
                string str = Console.ReadLine();
                str = str + '*';
                Console.WriteLine(str);
                break;
            default: Console.WriteLine("No such а choice");
                break;
        }
    }
}
