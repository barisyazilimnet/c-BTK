using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Barış KURT";
            Console.WriteLine(sentence.Length); // boşluklar dahil kaç karakter olduğu söler
            var result = sentence.Clone();
            sentence = "My name is Güldane AKSU";
            Console.WriteLine(result);
            Console.WriteLine(sentence.EndsWith("B")); // cümlenin sonu b ile bitiyor mu diye kontrol eder
            Console.WriteLine(sentence.EndsWith("Barış")); // cümlenin sonu barış ile bitiyor mu diye kontrol eder
            Console.WriteLine(sentence.StartsWith("B")); // cümlenin başı b ile başlıyor mu diye kontrol eder
            Console.WriteLine(sentence.StartsWith("Barış")); // cümlenin başı barış ile başlıyor mu diye kontrol eder
            Console.WriteLine(sentence.IndexOf("name")); // name kaçıncı karakterde başlıyor bulamadığı zaman -1 döndürür -- aramaya baştan başlar bulduğu ilk sonucu verir
            Console.WriteLine(sentence.IndexOf("is")); // name kaçıncı karakterde başlıyor bulamadığı zaman -1 döndürür -- aramaya baştan başlar bulduğu ilk sonucu verir
            Console.WriteLine(sentence.LastIndexOf("name")); // name kaçıncı karakterde başlıyor bulamadığı zaman -1 döndürür -- aramaya sondan başlar bulduğu ilk sonucu verir
            Console.WriteLine(sentence.Insert(0, "Hello, ")); // Cümlenin 0. karakterinden itibaren verilen içeriği ekler
            Console.WriteLine(sentence.Substring(3)); // belirtilen karakterden sonrasını alır belirtilen karakter dahildir.
            Console.WriteLine(sentence.Substring(3, 4)); // belirtilen karakterden sonra belirtilen karakter kadar alır belirtilen karakter dahildir.
            Console.WriteLine(sentence.ToLower()); // bütün karakterleri küçük harfe çevirir
            Console.WriteLine(sentence.ToUpper()); // bütün karakterleri büyük harfe çevirir
            Console.WriteLine(sentence.Replace(" ", "-")); // boşluk yerine - ekler
            Console.WriteLine(sentence.Remove(2)); //2. karakterden sonrası atar
            Console.WriteLine(sentence.Remove(2,5)); //2. karakterden sonra 5 tane karakter atar atar
            Console.ReadLine();
        }
        private static void Intro()
        {
            string city = "Antalya";
            Console.WriteLine(city[0]);

            Console.WriteLine("------");

            Console.WriteLine(city);

            Console.WriteLine("------");

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------");

            string city2 = "Alanya";
            Console.WriteLine(city + "/" + city2);

            Console.WriteLine("------");

            string result = String.Format("{0}/{1}", city, city2);
            Console.WriteLine(result);

            Console.WriteLine("------");

            Console.WriteLine(String.Format("{0}/{1}", city, city2));
        }

    }
}
