using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactroialusingRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factor(4).ToString());
            Console.WriteLine(factor(6).ToString());
            Console.WriteLine(factor(1).ToString());
            Console.WriteLine(factor(0).ToString());
        }
       
        public static int factor(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                return number * factor(number - 1);
            }
        }
    }
}
