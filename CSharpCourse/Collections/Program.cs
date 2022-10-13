using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ArrayList(); // tip güvenliği yoktur her türlüğü veriyi karışık olarak ekleyebilirsin
            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>(); // her değere key tanımlanabilir
            dictionary.Add("Book", "Kitap");
            dictionary.Add("Table", "Tablo");
            dictionary.Add("Computer", "Bilgisayar");
            Console.WriteLine(dictionary["Table"]);
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.ReadLine();
        }
        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
        private static void List()
        {
            List<string> cities = new List<string>();

            cities.Add("Ankara");
            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("------");

            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer { Id = 1, FirstName = "Barış" });
            customers.Add(new Customer { Id = 2, FirstName = "Güldane" });

            Console.WriteLine(customers.Count());

            var customer2 = new Customer { Id = 3, FirstName = "Beyza" };

            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id=4,FirstName="Bilge"},
                new Customer{Id=5,FirstName="Betül"}
            });

            //customers.Clear();
            Console.WriteLine(customers.Contains(customer2)); //dizi içinde aranan değer varmı -- diğer bilgiler sorgulandığında customer göndermek gerekli öle gönderildigi zaman referans tipi farklı oldğunu için false dönecektir
            var customer3 = new Customer { Id = 6, FirstName = "Efe" };
            Console.WriteLine(customers.Contains(customer3)); // referans tipi farklı olduğu için true dönecektir
            Console.WriteLine(customers.IndexOf(customer2)); //aramaya baştan başlar
            Console.WriteLine(customers.LastIndexOf(customer2)); // aramya sondan başlar
            customers.Insert(0, customer3); //içeriği kaçıncı sıraya eklemek istiyorsun
            customers.Remove(customer2);
            customers.RemoveAll(c => c.FirstName == "Efe"); //İsmi Efe olanı siler
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
