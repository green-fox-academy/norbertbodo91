using System;
using System.Linq;


namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbers = numbers.Where(b => b % 2 == 0);

            foreach (var evenNumber in evenNumbers)
            {
                Console.WriteLine(evenNumber);
            }

            Console.ReadLine();
        }
    }
}
