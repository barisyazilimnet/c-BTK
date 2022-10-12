using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
            // değerler degiştirelebilir
            //Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
            //Monday=10, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
            //Monday=10, Tuesday=20, Wednesday=30, Thursday=40, Friday=50, Saturday=60, Sunday=70
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.ReadLine(); // ekranın kapanmasını engeller herhangi bir tuşa basmadan ekran kapanmaz

            //int number1 = 10;
            //int number1 = -10;

            // int degerinin sınırı
            //int number1 = 2147483647;
            //int number1 = -2147483647;

            //Console.WriteLine(number1);
            //Console.WriteLine("Number1 is : {0}", number1); //indise göre yazdırma

            //long degerinin sınırı
            //long number2 = -9223372036854775808;
            //long number2 = 9223372036854775807;
            //Console.WriteLine("Number2 is : {0}", number2);

            //short degerinin sınırı
            //short number3 = -32768;
            //short number3 = 32767;
            //Console.WriteLine("Number3 is : {0}", number3);

            //byte degerinin sınırı
            //byte number4 = 0;
            //byte number4 = 255;
            //Console.WriteLine("Number4 is : {0}", number4);

            //bool degeri
            //bool condition = false;
            //bool condition = true;
            //Console.WriteLine("Condition is : {0}", condition);

            //char degeri
            //char character = 'a';
            //Console.WriteLine("Character is : {0}", character);

            //double degeri
            //double number5 = 10;
            //double number5 = 10.4;
            //Console.WriteLine("Number5 is : {0}", number5);

            //decimal degeri
            //decimal number6 = 10;
            //decimal number6 = 10.4m;
            //Console.WriteLine("Number6 is : {0}", number6);

            //enum degeri
            //Console.WriteLine(Days.Friday);
            //Console.WriteLine((int)Days.Friday); // veri tipini inte dönüştürür ve enumda tanımlanan sırayla sıfırdan başlayarak belirtilen degerin indis numarasını yazar

            //var değeri
            var number7 = 10;
            number7 = 'A'; // "" kullanıldığı zaman hata verir
            Console.WriteLine("Number7 is : {0}", number7);
            Console.ReadLine();
        }
    }
}
