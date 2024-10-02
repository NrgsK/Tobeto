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
            //string metinsel verileri tutmak için kullanılan değişken tipidir.

            //string city = "Ankara";

            // stringler aslında char dizisidir.
            // Console.WriteLine(city[0]);

            //foreach (var item in city)
            //{
            //    Console.WriteLine(item);

            //}

            //string city2 = "İstanbul";
            //string result = city + city2;

            //Console.WriteLine(String.Format("{0} {1}",city,city2));

            string sentence = "My name is Nergis Ketenci";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            // Yeni bir referans oluşturduk.
            sentence = "My name is Rukiye Ketenci";

            bool result3 = sentence.EndsWith("g");
            bool result4 = sentence.StartsWith("g");

            var result5 = sentence.IndexOf("name");
            // IndexOf bir string değişkende belli bir karakteri yada ifadeyi aramak için kullanılır. Aranan karakter bulunamazsa "-1" değeri döner.
            // Bulduğu ilk değerin indeksini yazar.

            var result6=sentence.IndexOf(" ");
            var result7=sentence.LastIndexOf(" "); //SAramaya sondan başlar.

            var result8=sentence.Insert(0,"Hello ");
            var result9=sentence.Substring(3,4);
            var result10=sentence.ToLower(); // bütün harfleri küçük yapmak için
            var result11=sentence.ToUpper(); // bütün harfleri büyük yapmak için
            var result12=sentence.Replace(" ","-");
            var result13=sentence.Remove(2,4);


            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            Console.WriteLine(result13);
            Console.ReadLine();
        }
    }
}
