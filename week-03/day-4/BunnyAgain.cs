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
            Console.WriteLine("Enter a Bunnies number: ");

            int bunnyNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entered Bunnies have : "+EarsCount(bunnyNumber)+" ears");

            Console.Read();
        }
        public static double EarsCount(int n)
        {
            if (n == 1)
            {
                return 2;
            }
            else
            {
                if (n%2==0)
                {
                    return 3 + EarsCount(n - 1);
                } 
                else
                {                
                    return 2 + EarsCount(n - 1);
                }
            
 
            }
        }
    }
}
