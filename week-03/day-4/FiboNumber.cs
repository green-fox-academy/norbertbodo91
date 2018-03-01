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
            Console.WriteLine("Enter a Fibo number: ");

            int fiboNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entered number Fibo's number is: "+ Fibo(fiboNumber));

            Console.Read();
        }
        public static double Fibo(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibo(n - 1) + Fibo(n - 2);
            }
            }
        }
    }

