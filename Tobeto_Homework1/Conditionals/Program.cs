using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Şart Blokları: belli bir şarta göre uygulamanın akışını değiştiren bloklardır.
            var number = 11;

            //        if (number==10) // mantıksal operatörler
            //        {
            //            Console.WriteLine("Number is 10");
            //        }
            //        else if(number == 20)
            //{
            //            Console.WriteLine("Number is 20");

            //        }
            //        else // Koşul sağlanmadığında
            //        {
            //            Console.WriteLine("Number is NOT 10 or 20");
            //        }

            //        // Alternatif yazım : Single Line If
            //        // (Şart bloğu ? doğruysa : yanlışsa)
            //        Console.WriteLine(number == 10 ? "Number is 10" : "Number is NOT 10");


            // Switch Bloğu
            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break;
            //    default:
            //        Console.WriteLine("Number is NOT 10 or 20");
            //        break;
            //}

            // Örnek Uygulama : Bir sayının 100lük dilimlerde nereye geldiğini bulma
            //if (number >= 0 && number <= 100)
            //{
            //    Console.WriteLine("Number is between 0-100");
            //}
            //else if (number > 100 && number <= 200)
            //{
            //    Console.WriteLine("Number is between 101-200");

            //}
            //else if (number > 200 || number < 0)
            //{
            //    Console.WriteLine("Number is less than 0 or greater than 200");

            //}



            // Nested (İç içe) If

            if (number < 100)
            {
                if (number >= 90 && number<95)
                {

                }
                else
                {
                    
                }
            }

            Console.ReadLine();
        }
    }
}
