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
            Console.WriteLine("Enter a Word with an X: ");

            string word = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Entered Word with an X turned into y, watch : " + ConvertXToY(word));

            Console.Read();
        }
        public static string ConvertXToY(string word)
        {
            if (word.Length == 1)
            {
                if (word == "x")
                {
                    return "y";
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
                    return word = "y" + ConvertXToY(word.Substring(1));                    
                }
                else
                {
                    return word = word[0] + ConvertXToY(word.Substring(1));
                }
            }
        }
    }
}

