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
            Console.WriteLine("Enter a word to add stars in it: ");

            string word = Console.ReadLine();

            Console.WriteLine("We added stars!!!(Shiny Magic :P) : " + PlusStarString(word));

            Console.Read();
        }
        public static string PlusStarString(string word)
        {
            if (word.Length == 2)
            {
                return word[0] + "*" + word[1];
            }
            else
            {
                return word[0] + "*" + PlusStarString(word.Substring(1));
            }
         
            
        }
    }
}

