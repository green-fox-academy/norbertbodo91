using System;
using System.Linq;


namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 3, 9, 2, 8, 6, 5 };

            var squaredNumbers = from number in numbers
                                 let SquaredNumber = number * number
                                 where SquaredNumber > 20
                                 select new { number, SquaredNumber };

            foreach (var squareNumber in squaredNumbers)
            {
                Console.WriteLine(squareNumber);
            }

            Console.ReadLine();
        }
    }
}
