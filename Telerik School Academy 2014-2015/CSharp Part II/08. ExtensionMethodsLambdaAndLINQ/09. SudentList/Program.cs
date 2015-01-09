using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SudentList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            students.Add(new Student("Ivan", "Georgiev", FN(), Phone(), "ivan.georgiev@abv.bg", Marks(6), 2));
            students.Add(new Student("Kancho", "Ivanov", FN(), Phone(), "kancho_ivanov@abv.bg", Marks(2), 1));
            students.Add(new Student("Hristofor", "Kolumbieca", FN(), Phone(), "H.Kolumbieca@abv.bg", Marks(6), 3));
            students.Add(new Student("Dinko", "Stefanov", FN(), Phone(), "StefanovDinko@abv.bg", Marks(6), 2));
            students.Add(new Student("Kiro", "Papazov", FN(), Phone(), "KiroP@abv.bg", Marks(6), 1));
            students.Add(new Student("Galq", "Petrova", FN(), Phone(), "Galkataaa@abv.bg", Marks(6), 1));
            students.Add(new Student("Kichka", "Veikova", FN(), Phone(), "SkivMySliv@abv.bg", Marks(6), 3));


            // problem 9
            Console.WriteLine("Problem 9");
            Console.WriteLine(new string('*', 80));
            var groupTwoStudents = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);
            foreach (var item in groupTwoStudents)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", item.FirstName, item.LastName, item.FN, item.Tel, item.GroupNumber);
            }
            Console.WriteLine();
            Console.WriteLine("Problem 10");
            Console.WriteLine(new string('*', 80));
            // problem 10

            List<Group> groups = new List<Group>()
            {
            new Group(1, "Physics"),
            new Group(2, "Mathematics"),
            new Group(3, "Biology")
            };

            List<Student> getStudents = students.GetStudentsByGroup(2);
            foreach (var item in getStudents)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", item.FirstName, item.LastName, item.FN, item.Tel, item.GroupNumber);
            }


            Console.WriteLine();
            Console.WriteLine("Problem 11");
            Console.WriteLine(new string('*', 80));
            // problem 11

            var email = students.Where(st => st.Email.Substring(st.Email.IndexOf('@') + 1) == "abv.bg");
            foreach (var item in email)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", item.FirstName, item.LastName, item.FN, item.Tel, item.GroupNumber);
            }


            Console.WriteLine();
            Console.WriteLine("Problem 12");
            Console.WriteLine(new string('*', 80));
            // problem 12
            var phone = students.Where(st => st.Tel.ToString().Substring(0, 1) == "2");
            foreach (var item in phone)
            {
                // autogenerate phone number, FN, Marks !!!!!
                Console.WriteLine("{0} {1} {2} {3} {4}", item.FirstName, item.LastName, item.FN, item.Tel, item.GroupNumber);
            }


            Console.WriteLine();
            Console.WriteLine("Problem 13");
            Console.WriteLine(new string('*', 80));
            // problem 13
            var byMarks = from st in students where st.Marks.Contains(6) select new { name = st.FirstName + " " + st.LastName };
            foreach (var item in byMarks)
            {
                // autogenerate phone number, FN, Marks !!!!!
                Console.WriteLine("{0}", item.name);
            }

            Console.WriteLine();
            Console.WriteLine("Problem 14");
            Console.WriteLine(new string('*', 80));
            // problem 14
            List<Student> studentsWith2Marks = students.GetStudentsBy2Marks(2);
            foreach (var item in studentsWith2Marks)
            {
                // autogenerate phone number, FN, Marks !!!!!
                Console.WriteLine("{0} {1}" + string.Join(" ", item.Marks), item.FirstName, item.LastName);
            }


            Console.WriteLine();
            Console.WriteLine("Problem 15");
            Console.WriteLine(new string('*', 80));
            // problem 15
            var marksEnrolled2006 = students.Where(st => st.FN.ToString().Substring(7, 2) == "06");
            foreach (var student in marksEnrolled2006)
            {
                // autogenerate phone number, FN, Marks !!!!!
                Console.WriteLine(string.Join(" ", student.Marks));
            }

            Console.WriteLine();
            Console.WriteLine("Problem 16");
            Console.WriteLine(new string('*', 80));
            // problem 16
            var studentsMath = from student in students
                               join gr in groups on student.GroupNumber equals gr.GroupNumber
                               where gr.GroupNumber == 2
                               select student;
            foreach (var st in studentsMath)
            {
                Console.WriteLine(st.FirstName);
            }



        }


        static List<int> Marks(int counter)
        {
            Random rnd = new Random();
            List<int> marks = new List<int>();
            for (int i = 0; i < counter; i++)
            {
                marks.Add(rnd.Next(2, 7));
            }
            return marks;
        }
        static int Phone()
        {
            Random rnd = new Random();
            int phone = rnd.Next(200000000, 900000000);
            return phone;
        }

        static int FN()
        {
            Random rnd = new Random();
            int fn = rnd.Next(0800000000, 0900000000);
            return fn;
        }
    }
}
