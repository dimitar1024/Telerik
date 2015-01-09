using System;

class MaleOrFemale
{
    static void Main()
    {
        Console.WriteLine("Enter your sex: Male/male or Female/female");
        string sex = Console.ReadLine();

        bool isMale;

        if ((sex == "male") || (sex == "Male"))
        {
            isMale = true;
            Console.WriteLine("Are you a man?  {0}", isMale);
        }
        else
        {
            isMale = false;
            Console.WriteLine("Are you a man?  {0}", isMale);
        }
    }
}

