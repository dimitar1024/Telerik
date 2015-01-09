using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Query
    {
        static void Main(string[] args)
        {
            TelerikAcademyEntities db = new TelerikAcademyEntities();

            var printEmployees = db.Employees
                .Select(em => em.FirstName + " " + em.Department.Name.ToString() + " " + em.Address.Town.Name)
                .ToList();

            foreach (var emp in printEmployees)
            {
                Console.WriteLine(emp);
            }


            var printWithInclude = db.Employees.Include("Address").Select(o => new
            {
                FirstName = o.FirstName,
                Department = o.Department.Name,
                Town = o.Address.Town.Name
            });

            foreach (var item in printWithInclude)
            {
                Console.WriteLine(item.FirstName + " - " + item.Department + " --- " + item.Town);
            }


            // Ако се чудите защо ги няма записите от двете заявки.
            // Отговорът е че конзолата има буфер на редовете, който може да се бърника от настройките
        }
    }
}
