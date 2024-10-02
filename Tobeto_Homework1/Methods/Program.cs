using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();

            //var result = Add2(20);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1); 
            // number1=20
            // metoda yalnızca değişkendeki değeri gönderiyoruz. (Değer tipler)
            // Eğer metotta gönderdiğimiz değerin bulunduğu değişkeni de değiştirmek istiyorsak ref keyword ünü kullanırız.
            // ref keyword ünün alternatifi out keyword üdür. Farkı ref te mutlaka değişkene değer atamalısın (set etmelisin), out ta böyle bir koşula gerek yok.

            //Console.WriteLine(result);
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add4(1,2,3,4,5,6));    
            Console.ReadLine();
        }

        // metotlar kod tekrarının önüne geçmemize yardımcı olur
        // Don't repeat yourself prensibi
        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2 = 30)
        //(parametre)
        {
            var result = number1 + number2;
            return result;

            // return number1 + number2;

            // burada bir işlem yapıldığı için void kullanmamız doğru değil
            // metodun dönüş tipine göre metot tipini belirliyoruz.

            // default parametre eğer parametre değeri verilmezse belirlediğimiz default değer kullanılır.

            // default değerler her zaman metotdun en sonundaki parametrede olması gerekir.(birden fazla default değer verilebilir.)

        }

        // Challenge

        static int Add3(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        // Method Overloading

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        // params keyword : tek tek parametre tanımlamak yerine
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }



    }
}
