using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(10);
            customer.Add();
            customer.List();
            Console.WriteLine("------");
            Customer customer1 = new Customer();
            customer1.Add();
            customer1.List();
            Console.WriteLine("------");

            Console.ReadLine();
        }
    }
    class Customer
    {
        private int _count = 20;
        public Customer()
        {

        }
        public Customer(int count) //cuntructor dır class çagırıldıgın ilk çalışacak methodur
        {
            _count = count;
        }

        public void List()
        {
            Console.WriteLine("Listed! {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private int _id;
        private string _name;
        public Product()
        {
        }
        public Product(int id, string name)
        {

            _id = Id;
            _name = Name;
        }
    }
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = _logger;
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }
}
