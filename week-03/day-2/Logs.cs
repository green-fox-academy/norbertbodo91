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
            string logs = @"C:\Users\Nope\source\repos\Yoo\Yoo\logs.txt";

            UniqueIP(logs);
            Console.Read();
        }
        public static void UniqueIP(string path)
        {
            string[] content = File.ReadAllLines(path);
            string[] splitedLines = new string[3];
            var ipList = new List<string>();

            foreach (string item in content)
            {
                splitedLines = item.Split("   ");
                ipList.Add(splitedLines[1]);
            }
            string[] uniqIp = ipList.Distinct().ToArray();
            for (int i = 0; i < uniqIp.Length; i++)
            {
                Console.WriteLine(uniqIp[i]);
            }

        }
        public static void GetPost(string path)
        {
            string[] content = File.ReadAllLines(path);
            string[] splitedLines = new string[3];
            int SumGet = 0;
            int SumPost = 0;

            foreach (var item in content)
            {
                splitedLines = item.Split("   ");
                if (splitedLines[2] == @"GET  \")
                {
                    SumGet++;
                }
                else
                {
                    SumPost++;
                }
            }
            Console.WriteLine(SumGet + "Get : "+ SumPost + "Post");

          
        }
    }
}


