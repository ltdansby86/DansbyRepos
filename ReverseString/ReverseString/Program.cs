using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
          reverseString("Race car");
        }

        public static void reverseString(string word)
    {
        int len = word.Length;
        int loc;
        char cur;
        string let;        
            if (len > 1 )
            {
                StringBuilder rword = new StringBuilder();
                
                while ( len > 0)
                {
                  loc = len - 1;
                  cur = word.ElementAt(loc);
                  let = cur.ToString();
                  rword.Append(let);
                  len--; 
                } 
                
                Console.WriteLine(rword.ToString());

            }
            else
            {
                Console.WriteLine(word.ToString());
            }
                 
    }
    }
}
