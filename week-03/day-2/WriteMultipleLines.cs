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


            MultipleLineWrite(path, "apple",10);
            string[] content = File.ReadAllLines(path);
            foreach (var write in content)
            {
                Console.WriteLine(write);
            }
            Console.ReadLine();
          

        }
        static void MultipleLineWrite(string path, string word,int lines)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < lines; i++)
                {
                    writer.WriteLine(word);
                }
                
            }
        }
    }
}


