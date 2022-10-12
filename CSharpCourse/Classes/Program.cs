using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Console.WriteLine("---------");

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Console.WriteLine("---------");

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Barış";
            customer.LastName = "KURT";
            customer.City = "Alanya";

            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Barış",
                LastName = "KURT",
                City = "Alanya"
            };
            Console.WriteLine(customer1.FirstName);
            Console.ReadLine();
        }
    }
}
