using System;
class FirmAccount
{
    static void Main()
    {
        Console.WriteLine("Enter first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter last  name");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter gender: ");
        string sex = Console.ReadLine();
        Console.WriteLine("Enter ID: ");
        string strId = Console.ReadLine();
        long id = long.Parse(strId);
        Console.WriteLine("Enter Unique employee number [27560000…27569999] UEN: ");
        long uen = long.Parse(Console.ReadLine());

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Your acount is create!");
        Console.ResetColor();
        Console.WriteLine(new string('=', 80));
        Console.WriteLine("   Welcome " + firstName + " " + lastName);
        if (age > 0 && age < 100)
        {
            Console.WriteLine("      Age: " + age);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ERROR! ");
            Console.ResetColor();
            Console.Write("Pleace enter age form interval [0..100]");
            Console.WriteLine();
        }
        if (sex == "Male" || sex == "male" || sex == "Female" || sex == "female")
        {
            Console.WriteLine("   Gender: " + sex);

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ERROR! ");
            Console.ResetColor();
            Console.Write("The gender is invalid");
            Console.WriteLine();
        }
        if (strId.Length != 10)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ERROR! ");
            Console.ResetColor();
            Console.Write("Please enter ten-digit number");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("ID number: " + id);
        }
        if (uen > 27560000 && uen < 27569999)
        {
            Console.WriteLine("      UEN: " + uen);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ERROR! ");
            Console.ResetColor();
            Console.Write("Pleace enter number form interval [27560000…27569999]");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

