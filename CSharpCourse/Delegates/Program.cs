using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int nnumber1, int number2);
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate();
            Console.WriteLine("------");
            myDelegate += customerManager.ShowAlert;
            myDelegate();
            Console.WriteLine("------");
            myDelegate -= customerManager.SendMessage;
            myDelegate();
            Console.WriteLine("------");

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2("Merhaba");
            Console.WriteLine("------");
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("Nasılsın"); //2 sinede aynı parametre veriliyor
            Console.WriteLine("------");

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            Console.WriteLine(myDelegate3(2, 3));
            Console.WriteLine("----");
            myDelegate3 += matematik.Carp;
            Console.WriteLine(myDelegate3(2, 3));
            Console.WriteLine("----");

            Console.ReadLine();
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be Creaful!");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }
    public class Matematik
    {
        public int Topla(int number1, int number2)
        {
            return number1 + number2;
        }
        public int Carp(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
