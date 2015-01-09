using System;
class PrintADeckOf52Cards
{
    static void Main()
    {
        string[] card = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] suit = { "Diamond", "Spade", "Clubs", "Heart" };
        string now = "";

        for (int j = 0; j < 4; j++)
        {
            for (int i = 0; i < 14; i++)
            {
                now = card[i] + " " +suit[j];
                Console.Write("{0} ", now);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
