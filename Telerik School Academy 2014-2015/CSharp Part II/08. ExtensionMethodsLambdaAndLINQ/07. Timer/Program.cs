using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07.Timer
{
    class Program
    {
        static void SetInterval(Action function, int tick) 
        {
            while (true)
            {
                Thread.Sleep(tick * 1000);

                function();
            }
        }
        static void Main(string[] args)
        {
            SetInterval(new Action(() => Console.WriteLine(DateTime.Now)), 1);
        }
    }
}
