using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine(NumberAdder(num));

            Console.Read();
        }
        public static int NumberAdder(int n)
        {
           
            if (n == 1)
            {
                return 1;
            }
            else
            {
                
                return n+NumberAdder(n-1);
            }
        }
    }
}
