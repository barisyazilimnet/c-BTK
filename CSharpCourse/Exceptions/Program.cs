using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            //TryCatch();
            //ActionDemo();
            //Console.WriteLine(Topla(2, 3));
            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3, 5));
            Console.WriteLine("---------");
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Func<int> getRandomNumber2=()=>new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber());
            Console.WriteLine("----");
            Thread.Sleep(1000);
            Console.WriteLine(getRandomNumber2());
            Console.ReadLine();
        }
        static int Topla(int x, int y)
        {
            return x + y;
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke(); //gönderilen methodu çalıştır demek
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Barış", "Güldane", "Beyza" };
                students[3] = "Bilge";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static void Find()
        {
            List<string> students = new List<string> { "Barış", "Güldane", "Beyza" };
            if (!students.Contains("Bilge"))
            {
                throw new RecordNotFoundException("Record Not Found");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }
        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        private static void ActionDemo()
        {
            HandleException(() => { Find(); });
        }
    }
}
