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
            string winO = @"C:\Users\Nope\source\repos\Yoo\Yoo\win-o.txt";
            string winX = @"C:\Users\Nope\source\repos\Yoo\Yoo\win-x.txt";
            string draw = @"C:\Users\Nope\source\repos\Yoo\Yoo\draw.txt";

            CheckYoo(draw);
            Console.Read();
          
        }
        static void CheckYoo(string path)
        {
            string[] content = File.ReadAllLines(path);
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i][0]== content[i][1] && content[i][1]== content[i][2] ||
                    content[0][i] == content[1][i] && content[1][i] == content[2][i] ||
                    content[0][0] == content[1][1] && content[1][1] == content[2][2])
                {
                  Console.WriteLine(content[0][0]); 
                }
                else
                {
                    Console.WriteLine("draw");
                }
                
            }
           

        }

    }
}


