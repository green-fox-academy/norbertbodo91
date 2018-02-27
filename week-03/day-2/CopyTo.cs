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
            string copyTo = @"C:\Users\Nope\Documents\projects\copyTo.txt";


            Console.WriteLine(CopyTo(path, copyTo));
            Console.ReadLine();


        }
        static bool CopyTo(string path, string copyTo)
        {
            try
            {
                string[] content = File.ReadAllLines(path);
                using (StreamWriter writer = new StreamWriter(copyTo))
                {
                    for (int i = 0; i < content.Length; i++)
                    {
                        writer.WriteLine(content[i]);
                    }

                }

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

    }
}


