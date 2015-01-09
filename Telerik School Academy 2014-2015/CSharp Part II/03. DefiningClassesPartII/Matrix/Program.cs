using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> m1 = new Matrix<int>(3, 3);
            Matrix<int> m2 = new Matrix<int>(3, 3);
            

            //fill
            Random rnd = new Random();
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {
                    m1[i, j] = rnd.Next(20);
                    m2[i, j] = rnd.Next(20);
                }
            }
            Console.WriteLine("Matrix 1");
            Console.WriteLine(m1);
            Console.WriteLine("Matrix 2");
            Console.WriteLine(m2);

            Console.WriteLine("Operator +");
            Console.WriteLine(m1 + m2);
        }
    }
}
