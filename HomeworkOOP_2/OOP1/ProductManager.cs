using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        //Ürünle ilgili operasyonlar burda gerçekleşir.
        //Encapsulation

        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");

        }

        //void : geriye bir değer döndürmezler.
        // geriye bir değer döndürmek ve bu değeri kullanmak istiyorsak "return" kullanmalıyız.

    }
}
