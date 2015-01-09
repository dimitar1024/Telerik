using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute.cs
{
    [VersionAttribute("2.11")]
    class Program
    {
        
        static void Main(string[] args)
        {
            object[] version = typeof(Program).GetCustomAttributes(typeof(VersionAttribute), false);

            Console.WriteLine("Version" + version[0]);
        }
    }
}
