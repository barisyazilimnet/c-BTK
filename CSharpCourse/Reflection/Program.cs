using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla(4, 5));
            //Console.WriteLine(dortIslem.Topla2());

            var tip = typeof(DortIslem);
            //DortIslem dortislem = (DortIslem)Activator.CreateInstance(tip,6,7);
            //Console.WriteLine(dortislem.Topla(4, 5));
            //Console.WriteLine(dortislem.Topla2());

            //var instance = (DortIslem)Activator.CreateInstance(tip, 6, 7);
            //Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));
            //MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            //Console.WriteLine(methodInfo.Invoke(instance, null));

            var methodlar = tip.GetMethods();
            foreach (var method in methodlar)
            {
                Console.WriteLine("Method Adı : {0}",method.Name);
                foreach (var methodParams in method.GetParameters())
                {
                    Console.WriteLine("Parametre Adı : {0}",methodParams.Name);
                }
                foreach (var methodCustomAttributes in method.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Adı : {0}",methodCustomAttributes.GetType().Name);
                }
            }
            Console.ReadLine();
        }
    }
    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }
}
