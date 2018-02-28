using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal kutya = new Animal();
            kutya.Eat();
            kutya.Drink();
            kutya.Play();

            Console.WriteLine(kutya.hunger +"  "+ kutya.thirst);

            Console.Read();
        }

    }
}
