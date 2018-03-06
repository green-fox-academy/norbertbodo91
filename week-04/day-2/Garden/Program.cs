using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GÁRDENÁPP
{
    class Program
    {
        static void Main(string[] args)
        {
            var garden = new Garden();
            
            garden.AddFlower(new Flower("yellow",4));
            garden.AddFlower(new Flower("blue", 4));

            garden.AddTree(new Tree("purple", 9));
            garden.AddTree(new Tree("orange", 9));

            garden.CheckPlant();

            garden.WateringPlant(40);

            garden.CheckPlant();

            garden.WateringPlant(70);

            garden.CheckPlant();

            Console.ReadLine();

        }
    }
}
