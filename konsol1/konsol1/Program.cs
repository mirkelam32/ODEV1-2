using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsol1
{
    class Program
    {
        
      
        static void Main(string[] args)
        {



            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------  V E R İ       T İ P L E R İ  ------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");

            // kullanıcıya bir veri tiplerini bildiriyoruz. Örnekleriyle..

            Console.WriteLine("int        \twhole number \n\t\t(integers)\t\t\t32 bit      \t-2^31\n\t\t\t\t\t\t\t\t2^31-1    \t  \t \t int sayı = 80");           
            Console.WriteLine("");


            Console.WriteLine("long      \twhole number\n\t\t(bigger range)\t\t\t64 bit      \t-2^63\n\t\t\t\t\t\t\t\t2^63-1    \t  \t \t long = 1299l");           
            Console.WriteLine("");

            Console.WriteLine("float      \tfloating - point number\t\t32 bit      \t-3.4x10-^38\n\t\t\t\t\t\t\t\t3.4x10^38 \t \t \t float = 0.29f");           
            Console.WriteLine("");

            Console.WriteLine("double     \tdouble-precision\n\t\tmore accurate\n\t\tfloating point number\t\t64 bit      \t+-5.0 x 10-^324\n\t\t\t\t\t\t\t\t+- 1.7 x 10^308      \t\t double = 0.33d");           
            Console.WriteLine("");

            Console.WriteLine("decimal    \tmonetary values    \t\t128 bit         28 significant figures    \t decimal coin = 1.75m");          
            Console.WriteLine("");

            Console.WriteLine("string     \tsequence of character     \t16 bit      \tnot applicaple                   string vest \n\t\t\t\t\t\t\t\t\t\t\t\t vest=forty two ");        
            Console.WriteLine("");

            Console.WriteLine("char       \tsingle character       \t\t16 bit      \ta single character       \t char grill = '#'");       
            Console.WriteLine("");

            Console.WriteLine("bool       \tboolean       \t\t\t8 bit       \ttrue or false     \t\t bool teeth = false");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");




            Console.ReadLine();


            

            

        }
    }
}