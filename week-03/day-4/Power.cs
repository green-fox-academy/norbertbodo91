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
            Console.WriteLine("Enter a Base Number: ");
            double baseValue= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a Exponent value of it: ");
            int exponentValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result : "+"["+Power(baseValue,exponentValue)+"]");

            Console.Read();
        }
        public static double Power(double basevalue, int exponentvalue)
        {
            if (exponentvalue == 0)
            {
                return 1;
            }
            if (exponentvalue == 1)
            {
                return basevalue;
            }
            return basevalue * Power(basevalue, exponentvalue - 1);
        }
    }
}
