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
            int num = 555;
            Console.WriteLine(SumDigit(num));

            Console.Read();
        }
        public static int SumDigit(int n)
        {
       
            if (n != 0)
            {
                return (n % 10 + SumDigit(n / 10)); ;
            }
            else
            {
                
                return 0;
            }
        }
    }
}
