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
            Factorial(1);

        }

       static void Factorial(int fac)
        {
            
           if (fac == 0)
           {
               Console.WriteLine("1");
           }
           else
           {
               int result = 1;
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
