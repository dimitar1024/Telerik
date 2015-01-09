using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            FindOrdersByDataAndRegion("1997-09-25","1997-10-24","Germany");
        }

        static void FindOrdersByDataAndRegion(string startDate, string endDate, string region) 
        {
            DateTime start = DateTime.Parse(startDate);
            DateTime end = DateTime.Parse(endDate);

            using (NorthwindEntities db = new NorthwindEntities()) 
            {
                var query = db.Orders
                            .Where(d => d.OrderDate >= start && d.OrderDate <= end && d.ShipCountry == region)
                            .Select(o => o.ShipName);

                foreach (var q in query)
                {
                    Console.WriteLine(q);
                }
            }

            
        }
    }
}
