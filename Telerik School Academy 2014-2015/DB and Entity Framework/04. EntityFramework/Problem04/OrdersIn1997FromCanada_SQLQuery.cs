using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class OrdersIn1997FromCanada_SQLQuery
    {
        static void Main(string[] args)
        {

            using (NorthwindEntities db = new NorthwindEntities())
            {

                var customers = db.Database.SqlQuery<string>(@"SELECT c.CompanyName FROM Orders o 
	                                                                         JOIN Customers c ON o.CustomerID = c.CustomerID
                                                                          WHERE YEAR(o.OrderDate) = 1997 AND o.ShipCountry = 'Canada'
                                                                          GROUP BY c.CompanyName");
                db.SaveChanges();

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer);
                }
            }
        }
    }
}
