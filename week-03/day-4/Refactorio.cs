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
            Console.WriteLine("Enter a number to its factoriozz: ");

            int factorio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factoriooo-yo-yo: " + Refactorio(factorio));

            Console.Read();
        }
        public static int Refactorio(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Refactorio(n - 1);
            }
        }
    }
}

