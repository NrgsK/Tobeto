using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inheritance - Kalıtım/Miras 
            //Interface den farklı olarak sınıfların birden fazla inheritance leri olmaz.
            //Önce Inheritance yazılır sonra interface(ler) yazılır.
            //Inheritance tek başına anlamlıdır.
            //Customer customer = new Customer();
            Person[] people = new Person[3]
            {
                new Customer{FirstName="Nergis"},
                new Student{FirstName="Furkan"},
                new Person{FirstName="Rukiye"}
            };
            foreach (Person person in people)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Person2
    {

    }

    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}
