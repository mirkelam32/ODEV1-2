using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            sor();
          
        }

        static void sor()
        {
            Console.WriteLine("Bir veri tipi giriniz.(yardım için h ye basınız.çıkmak için q ya basınız.)");
            string str = Console.ReadLine();

            if (str == "h")
            {
                Console.WriteLine("int float long double decimal string char bool");
                sor();
            }
            else if (str == "int")
            {
                Console.WriteLine("int, 32 bit yer kaplar , -2^31 - 2^31-1. int sayı = 80");
                sor();
            }
            else if (str == "long")
            {
                Console.WriteLine("long, 64 bit yer kaplar , -2^63 - 2^63-1, sonuna L koyulur.");
                sor();
            }
            else if (str == "float")
            {
                Console.WriteLine("float, 32 bit , -3.4x10-^38 - 3.4x10^38 , sonuna F koyulur");
                sor();
            }
            else if (str == "double")
            {
                Console.WriteLine("double, 64 bit ,  +-5.0 x 10-^324 - +- 1.7 x 10^308 .sonuna D koyulur.");
                sor();
            }
            else if (str == "decimal")
            {
                Console.WriteLine("decimal,  128 bit , decimal coin = 1.75m sonuna M koyulur.");
                sor();
            }
            else if (str == "string")
            {
                Console.WriteLine("string (karakter dizisi) , 16 bit  , örnek: string deyim = keyfi elli altı");
                sor();
            }
            else if (str == "char")
            {
                Console.WriteLine("char , özel karakter içerir , 16 bit , özel karakter , char grill = '#'");
                sor();
            }
            else if (str == "bool")
            {
                Console.WriteLine("bool, 8 bit , true(doğru)false(yanlış) , bool teeth = false");
                sor();
            }
            else if (str=="q")
            {
                return;
            }

            Console.ReadLine();
        }

    }
}
// bir veri tipi giriniz veri tiplerini öğrenmek için h ye basınız 
// h ye basılınca int  ( i ) long( lo ) decimal ( dec )  float ( flo ) 

//veri tipini gir
// double dub 
    // 