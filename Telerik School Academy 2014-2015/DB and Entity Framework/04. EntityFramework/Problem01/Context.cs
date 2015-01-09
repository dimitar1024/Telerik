using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Context
    {
        static void Main(string[] args)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {

                var quety = db.Products
                    .Where(p => p.ProductID <= 50)
                    .Select(p => p.ProductName);

                foreach (var item in quety)
                {
                    Console.WriteLine(item);
                }
            }
            
            
        }
    }
   
}
