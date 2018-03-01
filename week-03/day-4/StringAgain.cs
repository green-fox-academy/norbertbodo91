using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word which has an 'x' to remove it: ");

            string word = Console.ReadLine();

            Console.WriteLine("We removed it!!!(it's magic :P) : " + RmvX(word));

            Console.Read();
        }
        public static string RmvX(string word)
        {
            if (word.Length == 1)
            {
                if (word == "x")
                {
                    return string.Empty;
                }
                else
                {
                    return word;
                }
            }
            else
            {
                if (word[0] == 'x')
                {
                    return RmvX(word.Substring(1));
                }
                else
                {
                    return word[0] + RmvX(word.Substring(1));
                }
            }
        }
    }
}

