using System;
using System.Linq;


namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string exercise = "gggggggrrrrreeeennnffox";

            var frequency = from character in exercise
                            group character by character into frequencyChar
                            orderby frequencyChar.Count() descending
                            select frequencyChar;

            foreach (var character in frequency)
            {
                Console.WriteLine("Char " + character.Key + " appears " + character.Count() + " times");
            }
            Console.ReadLine();
        }
    }
}
