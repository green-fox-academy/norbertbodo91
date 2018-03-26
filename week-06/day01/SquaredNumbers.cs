using System;
using System.Linq;


namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var squaredNumbers = from number in numbers
                                 let SquaredNumber = number * number
                                 where number > 0
                                 select new { number, SquaredNumber };

            foreach (var squareNumber in squaredNumbers)
            {
                Console.WriteLine(squareNumber);
            }

            Console.ReadLine();
        }
    }
}
