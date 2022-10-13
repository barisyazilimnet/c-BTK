using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            Console.WriteLine("-------");
            Mysql mysql = new Mysql();
            mysql.Add();
            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add() // inheritance edildiğinde içeriği degiştirilmek istenirse virtual kullanılması gerekli
        {
            Console.WriteLine("Added by default");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }
    class SqlServer : Database
    {
        public void Add()
        {
            Console.WriteLine("Added by Sql Server");
            base.Add(); // database in add ini kullanır
        }
    }
    class Mysql : Database
    {

    }
}
