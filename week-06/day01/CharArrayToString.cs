using System;
using System.Linq;


namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] str = { 'g', 'r', 'e', 'e', 'n', 'f', 'o', 'x' };

            var charToString = string.Join("", str);
            var charToString2 = String.Concat(str);

            Console.WriteLine(charToString);
            Console.WriteLine(charToString2);
            Console.ReadLine();
        }
    }
}
