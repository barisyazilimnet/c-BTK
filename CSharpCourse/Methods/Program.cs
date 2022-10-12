using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Console.WriteLine(Add2(50, 20));
            Console.WriteLine(Add3(50, 20));
            Console.WriteLine(Add3());
            int number1 = 20;
            int number2 = 70;
            Console.WriteLine(number1);
            Console.WriteLine(Add4(ref number1, number2));
            Console.WriteLine(number1);
            int number3;
            int number4 = 70;
            Console.WriteLine(Add5(out number3, number4));
            Console.WriteLine(number3);
            Console.WriteLine(Multiply(5, 10));
            Console.WriteLine(Multiply(5, 10, 2));
            Console.WriteLine(Add6(5, 10, 6, 50, 100));
            Console.WriteLine(Add6(5, 10, 6));
            Console.WriteLine(Add6(5, 10, 6, 100, 12, 15, 17, 18, 10, 6, 100, 12, 15, 17, 18, 10, 6, 100, 12, 15, 17, 18, 10, 6, 100, 12, 15, 17, 18));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1, int number2)
        {
            return number1 + number2;
        }
        static int Add3(int number1 = 40, int number2 = 50)
        {
            return number1 + number2;
        }
        static int Add4(ref int number1, int number2) //gönderilen değişkenin referansını alır ve fonksiyon içinde değer değiştirilirse gönderilen değişkeninde değeri değişir
        {
            number1 = 100;
            return number1 + number2;
        }
        static int Add5(out int number3, int number4) //gönderilen değişkenin referansını alır ve fonksiyon içinde değer değiştirilirse gönderilen değişkeninde değeri değişir  
        {
            number3 = 100; // outda methodun içinde bir kere set edilmesi zorunludur. önceden tanımlanan değer önemli degildir.
            return number3 + number4;
        }
        static int Multiply(int number5, int number6)
        {
            return number5 * number6;
        }
        static int Multiply(int number5, int number6, int number7)
        {
            return number5 * number6 * number7;
        }
        static int Add6(params int[] numbers) // verilen bütün sayılara işlem yapar kaç tane sayı verildiği önemli değildir
        {
            return numbers.Sum();
        }
    }
}
