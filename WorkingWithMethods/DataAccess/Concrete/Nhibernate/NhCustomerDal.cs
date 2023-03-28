using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Nhibernate
{
    public class NhCustomerDal : ICustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Nhibernate kullanılarak veritabanına eklendi.");
        }
        public bool CustomerExists(Customer customer)
        {
            return true;
        }
    }
}
