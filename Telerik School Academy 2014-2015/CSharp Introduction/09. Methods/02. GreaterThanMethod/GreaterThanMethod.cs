using System;
class GreaterThanMethod
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            getMax(first, second, third);
        }

    public static void getMax(int f,int s,int t){
		int max = Math.Max(Math.Max(f, s), t);

        Console.WriteLine(max);
	}
    }
