using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        // Bir müşterinin özelliklerini tutmak için kullanılan nesnedir.

        public int Id { get; set; } // Property tanımlama
        private string _firstName;
        public string FirstName
        {
            get { return "Mr." + _firstName; }
            set { _firstName = value; }
        }
        //Bir field üzerinde değişiklik yapmak istediğimizde bu yöntemi kullanırız.
        //public string FirstName; //field - alan tanımlama
        public string LastName { get; set; }
        public string City { get; set; }

        //Encapsulation
    }
}
