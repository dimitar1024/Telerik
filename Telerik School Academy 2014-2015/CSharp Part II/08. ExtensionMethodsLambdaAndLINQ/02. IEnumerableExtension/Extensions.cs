using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableExtension
{
    public static class Extensions
    {

        private static T Filter<T>(this IEnumerable<T> items, Func<dynamic, T, T> func, dynamic first = null)
        {
            IEnumerator<T> i = items.GetEnumerator();
            i.MoveNext();
            T previous = first ?? i.Current;
            while (i.MoveNext())
                previous = func(i.Current, previous);
            return previous;
        }
        public static T Max<T>(this IEnumerable<T> items)
        {
            return items.Filter((a, b) => a > b ? a : b);
        }

        public static T Min<T>(this IEnumerable<T> items)
        {
            return items.Filter((a, b) => a < b ? a : b);
        }

        public static T Sum<T>(this IEnumerable<T> items)
        {
            return items.Filter((a, b) => a + b);
        }

        public static T Product<T>(this IEnumerable<T> items)
        {
            return items.Filter((a, b) => a * b);
        }

        //public static double Avg<T>(this IEnumerable<T> items)
        //{
        //    return Convert.ToDouble(items.Sum()) / items.Count();
        //}
        
        // I dont know convert T array in double or int 
    }
}
