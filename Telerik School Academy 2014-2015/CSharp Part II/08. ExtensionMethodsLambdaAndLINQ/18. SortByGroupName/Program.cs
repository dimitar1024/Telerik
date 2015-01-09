using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.SortByGroupName
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new[] {
                new{ FirstName = "Ivan" , LastName = "Georgiev", Age=19, Group = "Physics"},
                new{ FirstName = "Stefan" , LastName = "Popov", Age=21, Group = "Physics"},
                new{ FirstName = "Kancho" , LastName = "Angelov", Age=20, Group = "Math"},
                new{ FirstName = "Encho" , LastName = "Ivanov", Age=17, Group = "Math"},
                new{ FirstName = "Karina" , LastName = "Vlaeva", Age=18, Group = "Art"} // ♥Art
            };

            foreach (dynamic o in students)
            {
                Console.WriteLine(o.FirstName);
            }

            // Copy object form Problem 03 and Add prop 'group' :) 
            var sortByGroup = students.OrderBy(st => st.Group);

            foreach (var item in sortByGroup)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " -> "+ item.Group);
            }
        }
    }
}
