using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    //Add(2,3) --> 2+3
    internal class FourOperations
    {
        public void Add(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine("Sonuç : " + result);
        }
    }
}
