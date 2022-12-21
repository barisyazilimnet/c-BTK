using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "Barış" }, new Customer { FirstName = "Güldane" });
            foreach (var item in result2)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
    interface IRepository<T>
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T product);
        void Delete(T product);
        void Update(T product);
    }

    interface IProductDal : IRepository<Product>
    {

    }
    interface ICustomerDal : IRepository<Customer>
    {

    }
    class Product : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
    class Customer : ICustomerDal
    {
        public string FirstName { get; set; }
        public void Add(Customer product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer product)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer product)
        {
            throw new NotImplementedException();
        }
    }
}
