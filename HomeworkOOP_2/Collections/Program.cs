using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Nergis","Rukiye","Furkan","Nazmi"};
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //Diziler senin ilk tanımladığın sınırlar içinde işlem yapar. Bu sınırın dışına çıkamazsın

            //List<string> names2 = new List<string>();
            //names2.Add("Nergis");

            List<string> names2 = new List<string> { "Nergis","Rukiye","Nazmi","Furkan","Ayşen"};

            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);

            names2.Add("Aylin");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);



            Console.ReadKey();
        }
    }
}
