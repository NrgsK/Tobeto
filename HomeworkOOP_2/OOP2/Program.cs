using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Geçek Müşteri - Tüzel Müşteri
            //SOLID

            //Eğer bir veri üzerinde matematiksel herhangi bir işlem yapılmayacaksa verinin metinsel bir türde saklanması daha iyi olur.
            //**Eğer bir değer o nesneye ait değilmiş gibi duruyorsa soyutlama hatası yapıyorsun demektir.

            //Nergis Ketenci
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Nergis";
            customer1.LastName = "Ketenci";
            customer1.TCNo = "12345678900";

            //Kodlama.io
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            //Base - Temel Sınıf
            //new --> referans numarası
            //"Customer" sınıfı hem "IndividualCustomer" referansını hem de "CorporateCustomer" ın referansını tutabiliyor.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            Console.ReadKey();
        }
    }
}
