using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        Customer customer = new Customer { Id = 1, LastName = "Kurt", Age = 23 };
    }
    [ToTable("Customers")]
    [ToTable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }
    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew Method")] // bu fonksiyonu artık kullanmamanız gerektiğini söler -- içerisine açıklama yazmak zorunlu degildir
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }
    //[AttributeUsage(AttributeTargets.Class)] // attribute ın nerelerde kullanılacagını gösterir
    //[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)] // her ikisindede kulllanabilecegini gösterir
    [AttributeUsage(AttributeTargets.Property)]
    class RequiredPropertyAttribute : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)] //aynı yerde birden fazla kes kullanılabilir mi
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
