using System;
using System.Linq;


namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var oddNumbers = numbers.Where(b => b % 2 == 1);

            double average = numbers.Average();                      

            foreach (var oddNumber in oddNumbers)
            {
                Console.WriteLine(oddNumber);
            }

            Console.WriteLine("\nThe average is {0}.", average);

            Console.ReadLine();
        }
    }
}
