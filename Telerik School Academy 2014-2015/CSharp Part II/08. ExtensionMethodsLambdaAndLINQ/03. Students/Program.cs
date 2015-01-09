using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Students
{
    class Program
    {
        static void Print(IEnumerable students) 
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            } 
        }
        static void Main(string[] args)
        {

            var students = new[] {
                new{ FirstName = "Ivan" , LastName = "Georgiev", Age=19},
                new{ FirstName = "Stefan" , LastName = "Popov", Age=21},
                new{ FirstName = "Kancho" , LastName = "Angelov", Age=20},
                new{ FirstName = "Encho" , LastName = "Ivanov", Age=17},
                new{ FirstName = "Karina" , LastName = "Vlaeva", Age=18}
            };

            // Problem 3
            Console.WriteLine("Problem 3");
            Console.WriteLine(new string('*', 80));
            Print(students.Where(student => student.FirstName.CompareTo(student.LastName) < 0));

            // Problem 4
            Console.WriteLine("Problem 4");
            Console.WriteLine(new string('*', 80));
            Print(students.Where(student => student.Age < 24 && student.Age > 18));

            // Problem 5
            Console.WriteLine("Problem 5");
            Console.WriteLine(new string('*', 80));
            Print(students.OrderBy(student => student.FirstName).ThenBy(student => student.LastName));

            Console.WriteLine(new string('*', 80));
            Print( from student in students orderby student.FirstName descending, student.LastName descending select student);

        }
    }
}
