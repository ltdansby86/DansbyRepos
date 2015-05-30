using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeofTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            typeoftriangle(2, 2, 2);
            typeoftriangle(1, 2, 3);
        }

        public static void typeoftriangle(int a, int b, int c)
        {
            if (a==b && b==c)
            {
                Console.WriteLine("Equalateral Triangle");
            }
            if (a!=b && b!=c && a!=c)
            {
                Console.WriteLine("Oblique Triangle");
            }
            if (a==b && b!=c || a!=b && a==c)
            {
                Console.WriteLine("Isolease Triangle");
            }

        }
    }
}
