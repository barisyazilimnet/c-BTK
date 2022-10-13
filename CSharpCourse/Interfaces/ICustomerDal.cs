using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Server Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Server Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Server Updated");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }
    class MysqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Mysql Updated");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
