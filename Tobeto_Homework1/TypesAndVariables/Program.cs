using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://www.youtube.com/watch?v=LsIShglhTZg&list=PLqG356ExoxZU5keiJwuHDpXqULLffwRYD&index=7 1-37 numaralı dersler

            Console.WriteLine("Hello World!");

            // Value Types
            // int değişkeninin sınırları -2147483648 ile 2147483647 arasındadır.
            int number1 = 2147483647; // Değeri 10 olan bir değişken tanımla
            Console.WriteLine(number1);
            Console.WriteLine("Number1 is {0}",number1);
                       

            // long veri tipi int veri tipinin 2 katı kadar yer tutmaktadır.
            // long veri tipinin sınırları -9223372036854775808 ile 9223372036854775807 arasındadır.
            long number2 = 2147483648;
            Console.WriteLine("Number2 is {0}", number2);


            // short veri tipi 16 bitlik yer tutar. Sınırları -32768 ile 32767 arasındadır.
            short number3 = -32768;
            Console.WriteLine("Number3 is {0}", number3);


            // byte veri tipi 8 bitlik(1 byte) yer tutar. Sınırları 0 ile 255 arasındadır.
            byte number4 = 0;
            Console.WriteLine("Number4 is {0}", number4);


            // bool(mantıksal) veri tipi. true ve false değerlerini tutar.
            bool condition = true;


            // char veri tipi
            char character='A';
            Console.WriteLine("Character is : {0}",character);
            Console.WriteLine("Character(ASCII) is : {0}",(int)character); // Tanımlanan karakterin ASCII değerini yazırmak için böyle bir dönüşüm yapabiliriz.


            // double veri tipi ondalıklı sayı değerlerini tutar. Bellekte 64 bitlik yer tutar. 
            double number5 = 10.4;
            Console.WriteLine("Number5 is {0}", number5);


            // decimal veri tipi long veri tipi gibi daha büyük ondalıklı sayıları tutmak için kullanılır. Daha hassas değerler için kullanılması uygundur.(para vs.)
            decimal number6 = 10.4m;
            Console.WriteLine("Number6 is {0}", number6);

            // enum veri tipi (Magic string)
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday); //Kaçıncı sırada olduğunu görmek için başlangıç=0. istersek başlangıç değerini değiştirebiliyoruz.


            // var Keyword - değişken tutmak için kullanılır.
            var number7 = 10; // tanımladığımız değerin veri tipine göre var ın tipi değişir.
            number7 = 'A'; // ASCII karakter değeri
            // number7="A"; şeklinde bir tanımlama yapamayız. tanımlama string olduğu için int bir değere atama yapılamaz.
            Console.WriteLine("Number7 is {0}", number7);



            Console.ReadLine(); // Ekranda ne yazdığını görmek istiyorsak. Ekranı bekletir ve bir tuşa basmanı bekler sonrasında programı sonlandırır.


        }
    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,  Sunday
            //Monday=1 (başlangıç değerini değiştirme)
            // hepsine farklı değerler de atayabiliriz.
    }
}
