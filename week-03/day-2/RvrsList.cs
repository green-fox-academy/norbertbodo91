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

            RvrsLine(rvrs);
            Console.Read();
        }
        public static void RvrsLine(string file)
        {
            string[] allLines = File.ReadAllLines(file);

            foreach (var line in allLines)
            {
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    Console.Write(line[i]);
                }

                Console.WriteLine();
            }
        }
    }
}


