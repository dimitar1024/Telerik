using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08
{
    class EmployeeProgram
    {
        static void Main(string[] args)
        {
            NorthwindEntities db = new NorthwindEntities();

            Employee employee = new Employee();
            List<int> employees = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                employee = db.Employees.Find(i);
                employees.Add(employee.EmployeeID);
            }


            foreach (var line in employees)
            {
                Console.WriteLine(line);
            }
            
        }
    }
}
