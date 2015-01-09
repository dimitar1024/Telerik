using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Problem02;

namespace Problem01
{
    class DAO
    {
        static void Main(string[] args)
        {
            DAO.ModifyCustomer("ALFKI", "Nova Zagora");
            DAO.DeleteCustomer("ALFKI");
        }
        static void CreateNewCustomer(string customerName)
        {

            using (NorthwindEntities db = new NorthwindEntities())
            {
                Customer newCustomer = new Customer
                {
                    CompanyName = customerName
                };
                db.Customers.Add(newCustomer);
                db.SaveChanges();
                Console.WriteLine("The customer is created!");
            }
        }
        static void ModifyCustomer(string custId, string newName)
        {
            NorthwindEntities db = new NorthwindEntities();
            Customer customer = db.Customers.FirstOrDefault(p => p.CustomerID == custId);
            customer.CompanyName = newName;
            db.SaveChanges();
            Console.WriteLine("DateBese is updated!");
        }

        static void DeleteCustomer(string custId)
        {
            NorthwindEntities db = new NorthwindEntities();
            Customer customer = db.Customers.FirstOrDefault(p => p.CustomerID == custId);
            db.Customers.Remove(customer);
            db.SaveChanges();
            Console.WriteLine("Row from DataBase is removed!");
        }
    
    }
}
