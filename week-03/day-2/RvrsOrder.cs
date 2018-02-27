using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Yoo
{
    class Program
    {
        static void Main(string[] args)
        {
            string rvrs = @"C:\Users\Nope\source\repos\Yoo\Yoo\Rvrs.txt";

            RvrsOrder(rvrs);
            Console.Read();
        }
        public static void RvrsOrder(string file)
        {
            string[] lines = File.ReadAllLines(file);

            for (int i = lines.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(lines[i]);
            }
        }
    }
}


