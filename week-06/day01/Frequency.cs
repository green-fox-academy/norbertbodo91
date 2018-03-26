using System;
using System.Linq;


namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var frequency = from num in numbers
                            group num by num into frequencyNum
                            orderby frequencyNum.Count() descending
                            select frequencyNum;

            foreach (var num in frequency)
            {
                Console.WriteLine("Number " + num.Key + " appears " + num.Count() + " times");
            }

            Console.ReadLine();
        }
    }
}
