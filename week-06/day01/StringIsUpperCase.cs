using System;
using System.Linq;


namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "GrEenFoX";

            var upperStr = str.Where(x => char.IsUpper(x)).ToArray();

            foreach (var upperChar in upperStr)
            {
                Console.WriteLine(upperChar);
            }

            Console.ReadLine();
        }
    }
}
