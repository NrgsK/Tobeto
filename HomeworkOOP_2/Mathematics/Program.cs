using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FourOperations fourOperations = new FourOperations();
            fourOperations.Add(5, 6);
            fourOperations.Add(7, 8);

            Console.ReadKey();
        }
    }
}
