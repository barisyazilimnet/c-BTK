using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

            string[] cities = new string[] { "Alanya", "Antalya", "Gaziantep" };
            string[] cities2 = new string[] { "İstanbul", "Ankara", "İzmir" };
            cities2 = cities;
            cities[0] = "Konya";
            Console.WriteLine(cities2[0]);

            Console.ReadLine();
        }
    }
}
