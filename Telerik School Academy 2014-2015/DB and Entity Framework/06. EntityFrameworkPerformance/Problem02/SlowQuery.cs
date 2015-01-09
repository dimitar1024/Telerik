using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class SlowQuery
    {
        static void Main(string[] args)
        {
            TelerikAcademyEntities db = new TelerikAcademyEntities();

            var allEmployees = db.Employees.ToList()
             .Select(e => e.Address).ToList()
             .Select(e => e.Town).ToList()
             .Where(e => e.Name == "Sofia");

            foreach (var item in allEmployees)
            {
                Console.WriteLine(item.Name + " " + item.TownID);
            }


            Console.WriteLine(new string('*', 80));
            var allEmployeesOptimized = db.Employees
            .Select(e => e.Address)
            .Select(e => e.Town)
            .Where(e => e.Name == "Sofia").ToList();

            foreach (var item in allEmployeesOptimized)
            {
                Console.WriteLine(item.Name + " " + item.TownID);
            }
        }
    }
}
