using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem03;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {

                var CustomersQuery = db.Orders
                                    .Where(d => d.OrderDate.ToString().Contains("1997"))
                                    .OrderBy(t => t.ShipCountry == "Canada")
                                    .Select(d => (d.ShipName + " " + d.OrderDate).ToString());

                foreach (var order in CustomersQuery)
                {
                    Console.WriteLine(order);
                }
            }
        }
    }
}
