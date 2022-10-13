using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            HandleException(() => { Find(); });
            Console.ReadLine();
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
    }
}
