using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var reptile = new Reptile("Crocodile");
            var reptile1 = new Reptile("frog");
            var mammal = new Mammal("Goat");
            var bird = new Bird("Parrot");

            Console.WriteLine("Who want a baby?");
            Console.WriteLine(reptile.GetName() + ", " + reptile.WantChild());
            Console.WriteLine(mammal.GetName() + ", " + mammal.WantChild());
            Console.WriteLine(bird.GetName() + ", " + bird.WantChild());
            Console.WriteLine(reptile1.GetName() + ", " + reptile1.WantChild());

            Console.ReadLine();
        }
    }
}
