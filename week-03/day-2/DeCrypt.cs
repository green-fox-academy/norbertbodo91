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
            string deCrypt = @"C:\Users\Nope\source\repos\Yoo\Yoo\Decrypt.txt";

            DeCrypt(deCrypt);
            Console.Read();
        }
        public static void DeCrypt(string path)
        {
            string[] content = File.ReadAllLines(path);
            var contentList = new List<char>();

            foreach (var lines in content)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        contentList.Add(lines[i]);
                    }
                }

                contentList.Add('\n');
            }
            foreach (var crypt in contentList)
            {
                Console.Write(crypt);
            }
            

         }
    }
}


