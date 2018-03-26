using System;
using System.Collections.Generic;
using System.Linq;


namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            FoundGreenFox();

            Console.ReadLine();
        }
        static void FoundGreenFox()
        {
            var foxList = new List<Fox>()
            {
                new Fox{Name = "Vuk",Type = "pallida",Color = "green"},
                new Fox{Name = "Robert",Type = "pebble",Color = "red"},
                new Fox{Name = "Artica",Type = "corsac",Color = "white"},

            };

            var correctFoxes = from fox in foxList
                             where (fox.Color == "green") && (fox.Type == "pallida")
                             select fox;

            foreach (var correctFox in correctFoxes)
            {
                Console.WriteLine(correctFox.Name);
            }

        }
    }
}
