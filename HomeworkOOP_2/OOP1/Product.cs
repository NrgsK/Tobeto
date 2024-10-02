using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //Snippet - Hazır kodlar
    internal class Product
    {
        //Sadece özellik
        public int Id { get; set; }
        public int CategoryId { get; set; } //Foreign Key - Referans Alanı
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //CRUD - Create Read Update Delete

    }
}
