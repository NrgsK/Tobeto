using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        //Dal = Data Access Label
        // Polymorphism : Çok Biçimlilik
        // Bir nesneyi farklı amaçlarla implemente edip, belli bir kısmına ya da tamamına ulaşmak.

        void Add();
        void Update();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted!");

        }

        public void Update()
        {
            Console.WriteLine("Sql Updated!");

        }
    }
    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added!");

        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted!");

        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated!");

        }
    }
    class MySqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Added!");

        }

        public void Delete()
        {
            Console.WriteLine("MySql Deleted!");

        }

        public void Update()
        {
            Console.WriteLine("MySql Updated!");

        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
