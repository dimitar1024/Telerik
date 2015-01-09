using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07
{
    class Program
    {
        static void Main(string[] args)
        {

            using (NorthwindEntities firstDB = new NorthwindEntities())
            {
                using (NorthwindEntities secondDB = new NorthwindEntities())
                {
                    Customer first = firstDB.Customers.Find("ALFKI");
                    first.Region = "NZ";

                    Customer second = firstDB.Customers.Find("ANATRI");
                    first.Region = "SZ";

                    firstDB.SaveChanges();
                    secondDB.SaveChanges();
                }    
            }
        }
    }
}
