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
            string fileName = @"C:\Users\Nope\Documents\projects\my-file.txt";


            FileLines(fileName);
            Console.ReadLine();

        }
        static void FileLines(string fileName)
        {
            try
            {
                string[] content = File.ReadAllLines(fileName);
                Console.WriteLine(content.Length);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
        }
    }
}


