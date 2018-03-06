using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GÁRDENÁPP
{
    class Plant
    {
        protected string name;
        protected string color;
        protected double waterAmount;
        protected double wateringlevel;
        protected double absorbLevel;

        public Plant(string name,string color, double waterAmount, double wateringlevel, double absorbLevel)
        {
            this.name = name;
            this.waterAmount = waterAmount;
            this.color = color;
            this.wateringlevel = wateringlevel;
            this.absorbLevel = absorbLevel;
        }
        public bool ReadyForWatering()
        {
            return waterAmount <= wateringlevel;
        }
        public void Watering(double water)
        {
            waterAmount += water*(absorbLevel/100);
        }
        public double GetWaterAmount()
        {
            return waterAmount;
        }
        public string GetColor()
        {
            return color;
        }
        public string GetName()
        {
            return name;
        }
        
    }
}
