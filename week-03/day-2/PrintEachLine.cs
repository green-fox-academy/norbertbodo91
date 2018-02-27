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
            string path = @"C:\Users\Nope\Documents\projects\my-file.txt";
            try
            {
                // Reads the content from `lorem-psum.txt` in the `assets` folder line by line to a string List
                string[] content = File.ReadAllLines(path);
                foreach (var line in content)
                {
                    Console.WriteLine(line);
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }

            Console.ReadLine();

        }      

    }
}


