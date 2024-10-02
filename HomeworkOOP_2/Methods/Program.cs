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
            //Metotlar tekrar tekrar kullanılabilirliği sağlayan kod parçalarıdır.
            //DO NOT REPEAT YOURSELF - DRY
            //Class'lar oluşturarak bir nesne oluşturup onunla ilgili özellikleri bu classlar içerisinde tanımlanır.

            Product product1 = new Product(); //class'ın örneği oluşturulur.
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            //Type-safe
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("~~~~~~~~~~~~~~~~");
            }

            Console.WriteLine("---------Metotlar--------\n");

            //Instance - örnek oluşturma
            //Encapsulation : Kapsülleme - Düzen
            ShoppingCartManager shoppingCartManager = new ShoppingCartManager();
            shoppingCartManager.Add(product1);
            shoppingCartManager.Add(product2);

            shoppingCartManager.Add2("Armut", "Yeşil armut", 12, 10);
            shoppingCartManager.Add2("Elma", "Yeşil elma", 12, 5);
            shoppingCartManager.Add2("Karpuz", "Diyarbakır karpuzu", 12, 8);


            Console.ReadKey();
        }
    }
}
