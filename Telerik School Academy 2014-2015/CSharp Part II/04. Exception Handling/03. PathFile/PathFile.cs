using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PathFile
{
    class PathFile
    {
        static void Main()
        {
            Console.Write("Enter real path name");
            try
            {
                Console.WriteLine(File.ReadAllText(Console.ReadLine()));
            }
            catch (Exception er)
            {
                Console.WriteLine("Error!\n{0}:{1}", er.GetType().Name, er.Message);
            }
        }
    }
}
