using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;
            // number1 = 30

            int[] numbers1=new int[] { 10,20,30};
            int[] numbers2=new int[] { 100,200,300};

            numbers1 = numbers2;
            numbers2[0] = 999;
            // numbers1[0] = 999

            // Sayısal veri tipleri : int,decimal,float,bool --> Değer Tip
            //array,class,interface --> Referans Tip

            // Stack : Değer Tipler burada gerçekleşir.
            // Heap : new keyword'ü ile heap'te değişkenin adresi oluşur.

            //Değer Tiplerde değeri atarsın, Referans Tiplerde adresi atarsın.

        }
    }
}
