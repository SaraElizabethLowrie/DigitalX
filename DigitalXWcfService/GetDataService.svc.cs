using DigitalXEntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DigitalXWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GetDataService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GetDataService.svc or GetDataService.svc.cs at the Solution Explorer and start debugging.
    public class GetDataService : IGetDataService
    {
        public void DoWork()
        {
        }

        // Product
        public IList<Product> ProductGetAll()
        {
            using (var pro = new DigitalXDBModel())
            {
                var products = pro.Products.ToList();
                return products;
            }
        }

        public Product ProductGetDetails(int? id)
        {
            using (var pro = new DigitalXDBModel())
            {
                var products = pro.Products.Find(id);
                return products;
            }
        }

        public IList<Product> ProductGetTop(int count)
        {
            using (DigitalXDBModel db = new DigitalXDBModel())
            {
                var products = db.Products.OrderByDescending(p => p.OrderDetails.Count).Take(count).ToList();
                return products;
            }
        }

        // Customer
        public bool CreateCustomer(string UserName)
        {
            using (DigitalXDBModel db = new DigitalXDBModel())
            {
                try
                {
                    Customer c = new Customer();
                    c.UserName = UserName;
                    //c.FirstName = customer.FirstName;
                    //c.LastName = customer.LastName;
                    //c.Email = customer.Email;
                    //c.Password = customer.Password;
                    db.Customers.Add(c);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public IList<Customer> GetCustomer()
        {
            using (DigitalXDBModel db = new DigitalXDBModel())
            {
                var customers = db.Customers.ToList();
                return customers;
            }
        }

        public Customer GetCustomerId(int? id)
        {
            using (DigitalXDBModel db = new DigitalXDBModel())
            {
                var customers = db.Customers.Find(id);
                return customers;
            }
        }

        public Customer CustomerLogin()
        {
            using (DigitalXDBModel db = new DigitalXDBModel())
            {
                var user = db.Customers.Where(c => c.UserName == c.UserName & c.Password == c.Password).FirstOrDefault();
                if (user != null)
                {
                    user.UserName.ToString();
                    user.Password.ToString();
                }
                return user;
            }
        }
    }
}
