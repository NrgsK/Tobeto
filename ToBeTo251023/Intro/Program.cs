using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            //loginControl();

            //conditionalsDollar();

            //arrayCourse();



            Console.ReadKey();

            void Intro()
            {
                int number = 10;
                int number2 = 11;
                string city = "Ankara";
                char firstLetter = 'a';
                double number3 = 3.4;
                bool isItCorrect = false;
            }

            void conditionalsDollar()
            {
                double dollarYesterday = 27.40;
                double dollarToday = 27.50;
                if (dollarToday > dollarYesterday)
                {
                    Console.WriteLine("UP");
                }
                else if (dollarToday == dollarYesterday)
                {
                    Console.WriteLine("EQUAL");
                }
                else
                {
                    Console.WriteLine("DOWN");
                }
            }

            void arrayCourse()
            {
                string[] courses = new string[] { "C#", "Java", "Python", "C++", "JavaScript" };
                Console.WriteLine("<ul>");
                foreach (string course in courses)
                {
                    Console.WriteLine("<li>" + course + "</li>");
                }
                Console.WriteLine("</ul>");
            }
        }

        private static void loginControl()
        {
            bool isLoggedIn = false;
            string button1 = "<button>Giriş Yap</button>";
            string button2 = "<button>Çıkış Yap</button>";

            if (isLoggedIn == false) // şartın sağlanması durumu. verilen şart doğruysa if in içine girer
            {
                Console.WriteLine(button1);
            }
            else
            {
                Console.WriteLine(button2);
            }
        }
    }
}
