using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Barış";
            string student2 = "Güldane";
            string student3 = "Ali";
            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student3);

            Console.WriteLine("--------");

            string[] students = new string[3]; // 3 elemanlı dizi tanımlandı
            students[0] = "Barış";
            students[1] = "Güldane";
            students[2] = "Ali";
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("--------");

            string[] students2 = new[] { "Barış", "Güldane", "Ali" };
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("--------");

            string[] students3 = { "Barış", "Güldane", "Ali" };
            foreach (var student in students3)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("--------");

            string[] students4 = new string[3] { "Barış", "Güldane", "Ali" };
            foreach (var student in students4)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("--------");

            string[,] regions = new string[7, 3];
            regions[0, 0] = "İstanbul";

            string[,] regions2 = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" }
            };
            for (int i = 0; i <= regions2.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions2.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions2[i,j]);
                }
                Console.WriteLine("--");
            }
            Console.ReadLine();
        }
    }
}
