using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExtensionMethod
{
    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length) 
        {
            return new StringBuilder(str.ToString(index, length));
        }
    }
}
