using System;
using System.Numerics;

class CatalanNumber
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger factorielN = 1;
        BigInteger ntwo = 2 * n;
        BigInteger factorielNtwo = 1;
        BigInteger nplus1 = n + 1;
        BigInteger factorielNplus1 = 1;
        BigInteger result;
        if (n >= 0)
        {
            do
            {
                factorielN *= n;
                n--;

            } while (n > 0);

            do
            {
                factorielNtwo *= ntwo;
                ntwo--;
            } while (ntwo > 0);

            do
            {
                factorielNplus1 *= nplus1;
                nplus1--;
            } while (nplus1 > 0);

            result = (factorielNtwo / (factorielNplus1 * factorielN));

            Console.WriteLine("(2n)!/((n+1)!n!) = " + result);


        }
    }
}
