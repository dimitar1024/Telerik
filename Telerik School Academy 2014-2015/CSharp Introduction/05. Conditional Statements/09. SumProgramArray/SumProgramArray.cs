using System;
class SumProgramArray
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter five numbers");
        int[] array = new int[5];
        array[0] = int.Parse(Console.ReadLine());
        array[1] = int.Parse(Console.ReadLine());
        array[2] = int.Parse(Console.ReadLine());
        array[3] = int.Parse(Console.ReadLine());
        array[4] = int.Parse(Console.ReadLine());
        int result = 0;
        if ((array[0] + array[1]) == 0)
        {
            Console.WriteLine("{0} + {1} is 0", array[0], array[1]);
            result = 1;
        }
        if ((array[0] + array[2]) == 0)
        {
            Console.WriteLine("{0} + {1} is 0", array[0], array[2]);
            result = 1;
        }
        if ((array[0] + array[3]) == 0)
        {
            Console.WriteLine("{0} + {1} is 0", array[0], array[3]);
            result = 1;
        }
        if ((array[0] + array[4]) == 0)
        {
            Console.WriteLine("{0} + {1} is 0", array[0], array[4]);
            result = 1;
        }
        if ((array[1] + array[2]) == 0)
        {
            Console.WriteLine("{0} + {1} is 0", array[1], array[2]);
            result = 1;
        }
        if ((array[1] + array[3]) == 0)
        {
            Console.WriteLine("{0} + {1} is 0", array[1], array[3]);
            result = 1;
        }
        if ((array[1] + array[4]) == 0)
        {
            Console.WriteLine("{0} + {1} is 0", array[1], array[4]);
            result = 1;
        }
        if ((array[2] + array[3]) == 0)
        {
            Console.WriteLine("{0} + {1} is 0", array[2], array[3]);
            result = 1;
        }
        if ((array[2] + array[4]) == 0)
        {
            Console.WriteLine("{0} + {1} is 0", array[2], array[4]);
            result = 1;
        }
        if ((array[3] + array[4]) == 0)
        {
            Console.WriteLine("{0} + {1} is 0", array[3], array[4]);
            result = 1;
        }

        if ((array[0] + array[1] + array[2]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} is 0", array[0], array[1], array[2]);
            result = 1;
        }
        if ((array[0] + array[1] + array[3]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} is 0", array[0], array[1], array[3]);
            result = 1;
        }
        if ((array[0] + array[1] + array[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} is 0", array[0], array[1], array[4]);
            result = 1;
        }
        if ((array[0] + array[2] + array[3]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} is 0", array[0], array[2], array[3]);
            result = 1;
        }
        if ((array[0] + array[2] + array[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} is 0", array[0], array[2], array[4]);
            result = 1;
        }
        if ((array[0] + array[3] + array[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} is 0", array[0], array[3], array[4]);
            result = 1;
        }
        if ((array[1] + array[2] + array[3]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} is 0", array[1], array[2], array[3]);
            result = 1;
        }
        if ((array[1] + array[2] + array[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} is 0", array[1], array[2], array[4]);
            result = 1;
        }
        if ((array[1] + array[3] + array[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} is 0", array[1], array[3], array[4]);
            result = 1;
        }
        if ((array[2] + array[3] + array[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} is 0", array[2], array[3], array[4]);
            result = 1;
        }

        if ((array[0] + array[1] + array[2] + array[3]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} +{3} is 0", array[0], array[1], array[2], array[3]);
            result = 1;
        }
        if ((array[0] + array[1] + array[2] + array[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} +{3} is 0", array[0], array[1], array[2], array[4]);
            result = 1;
        }
        if ((array[0] + array[2] + array[3] + array[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} +{3} is 0", array[0], array[2], array[3], array[4]);
            result = 1;
        }
        if ((array[1] + array[2] + array[3] + array[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} +{3} is 0", array[1], array[2], array[3], array[4]);
            result = 1;
        }

        if ((array[0] + array[1] + array[2] + array[3] + array[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} is 0", array[0], array[1], array[2], array[3], array[4]);
            result = 1;
        }

        if (result == 0) Console.WriteLine("No subset sum of 0 found");
    }
}
