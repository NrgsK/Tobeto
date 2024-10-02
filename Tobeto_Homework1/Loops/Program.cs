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
            // Döngüler veri kümesinin içerisinde dolaşmak için kullandığımız yapılardır.
            // for(başlangıç değeri,şart,artış)

            //for (int i = 100; i >= 0; i-=2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Finished!");


            // While Döngüsü: Belli bir şart sağlanana kadar döngü çalışır.
            //int number = 100;
            //while (number>=0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //    // Sonsuz döngü olmaması için döngünün içerisinde şarta müdahale etmek gerekir.
            //}
            //Console.WriteLine("Now number is {0}",number);


            //Do-While Döngüsü
            //Şarta bakmadan döngü bir kez çalışır.

            //int number = 10;
            //do
            //{
            //    Console.WriteLine(number);
            //    number--;

            //} while (number>=11);


            //Foreach döngüsü 
            // Dizi temelli verilerin içinde dolaşabilmek için kullanılır.


            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {
                // Dizideki elemanları bu döngü içerisinde değiştiremeyiz.
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }
    }
}
