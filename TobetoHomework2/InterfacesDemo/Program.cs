using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir şiket - Üç çalışan tipi -> İşçiler,yöneticiler ve robotlar
            //SOLID - Yazılım Geliştirme Prensibi

            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                    new Worker(),
                    new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

            Console.ReadLine();
        }
    }
    interface IWorker
    {
        void Work();

    }
    interface IEat
    {
        void Eat();

    }
    interface ISalary
    {
        void GetSalary();

    }
    //Birden fazla interface tanımlayabiliriz.
    // Bir class birden fazla interface yi implemente edebilir.
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager Eated!");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager Paid!");

        }

        public void Work()
        {
            Console.WriteLine("Manager Worked!");

        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker Eated!");

        }

        public void GetSalary()
        {
            Console.WriteLine("Worker Paid!");

        }

        public void Work()
        {
            Console.WriteLine("Worker Worked!");

        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Worked!");

        }
    }
}
