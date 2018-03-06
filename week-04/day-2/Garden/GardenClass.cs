using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GÁRDENÁPP
{
    class Garden
    {
        
        List<Plant> plants;

        public Garden()
        {           
            plants = new List<Plant>();
        }
        public void AddFlower(Flower flower)
        {
            plants.Add(flower);
        }
        public void AddTree(Tree tree)
        {
            plants.Add(tree);
        }        
        public void WateringPlant(double waterOfAmount)
        {
            var newPlantList = new List<Plant>();

            Console.WriteLine("\n Watering with " + waterOfAmount+"\n");

            foreach (var plant in plants)
            {
                if (plant.ReadyForWatering() == true)
                {
                    newPlantList.Add(plant);
                }                        
            }

            waterOfAmount = waterOfAmount / newPlantList.Count;

            foreach (var plant in newPlantList)
            {
                
                plant.Watering(waterOfAmount);
            }
        }
        public void CheckPlant()
        {
            foreach (var plant in plants)
            {
                if (plant.ReadyForWatering() == true)
                {
                Console.WriteLine("The " + plant.GetColor() +" "+ plant.GetName() + " needs water.");
                }
                else
                {
                Console.WriteLine("The " + plant.GetColor() +" "+ plant.GetName() + " doesnt need water.");
                }
            }
        }
    }
}
