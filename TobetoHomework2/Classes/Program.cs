using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class amacı yapılmak istenen işlemleri gruplara ayırmak, bu gruplar üzerinden işlemler yapmak ve rahat bir şekilde bu gruplara ulaşmak.
            //Sınıfları kullanabilmek için main de birer örnek oluşturmak gerekir.
            CustomerManager customerManager = new CustomerManager(); // Class ın bir örneği oluşturuldu
            customerManager.Add();
            customerManager.Update();


            ProductManager productManager = new ProductManager();
            // Çalışacağımız nesne ile ilgili önce örnek oluşturuyoruz sonrasında içerisindeki metotları çağırıyoruz.
            productManager.Add();
            productManager.Update();

            // Sınıflar property(özellik) denilen nesneleri tutar.
            Customer customer = new Customer(); //Sınıf örnek oluşturma 1. Yöntem
            customer.City = "Rize";
            customer.FirstName = "Nergis"; // set bloğu çalışır. değer verilir.(yazma)
            customer.LastName = "Ketenci";
            customer.Id = 1;

            Customer customer2= new Customer //Sınıf örnek oluşturma 2. Yöntem
            { 
                Id = 2,
                City="Rize",
                FirstName="Furkan",
                LastName="Ketenci"
            };

            Console.WriteLine(customer2.FirstName); // get bloğu çalışır. verilen değer alınır.(okuma)

            Console.ReadLine();

        }
    }



}
