using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer // default internaldır -- aynı proje içinde kullanılmasına izin verir
    {
        //int Id; // defaul privatedır -- tanımlandığı blok içerisinde geçerlidir
        //protected int Id; // tanımlandığı blok içerisinde ve inheritance içerisinde geçerlidir
        public string Name { get; set; } // başka projelerde de kullanılabilmesi için verilir ama başka projelerde kullanılırken referans verilmesi gereklidir.
    }
    class Student
    {
        public void Save()
        {

        }
    }
}
