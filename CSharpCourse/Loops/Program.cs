using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int number = 100;
            //while (number>=0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}

            //int number2 = 10;
            //do
            //{
            //    Console.WriteLine(number2);
            //    number2--;
            //} while (number2>=11);

            //string[] students = { "Barış", "Güldane", "Ali" };
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}

            bool IsPrimeNumber(int number)
            {
                bool result = true;
                for (int i = 2; i < number - 1; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        i=number;
                    }
                }
                return result;
            }
            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a pirme number");
            }

            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}
