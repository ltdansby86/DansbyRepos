using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial(4);
            Factorial(10);

        }

       static void Factorial(int fac)
        {
            int result = 1;
           if (fac == 0)
           {
               Console.WriteLine("1");
           }
           else
           {
               while( fac > 0)
               {
                   result = result * fac;
                   fac--;
               }

               Console.WriteLine(result.ToString());
           }
        }


    }
}
