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


            WriteFile(fileName);
            string[] content = File.ReadAllLines(fileName);
            foreach (var write in content)
            {
                Console.WriteLine(write);
            }
            Console.ReadLine();
          

        }
        static void WriteFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Norbert Bodo");
            }
        }
    }
}


