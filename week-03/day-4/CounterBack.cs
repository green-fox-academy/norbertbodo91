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
            int num = 10;
            Console.WriteLine(counter(num));

            Console.Read();
        }
        public static int counter(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                Console.WriteLine(n);
                return counter(n-1);
            }
        }
    }
}
