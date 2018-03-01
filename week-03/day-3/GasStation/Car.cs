using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Car
    {
        private int gasAmount;
        private int capacity;
        
        public Car()
        {
            gasAmount = 0;
            capacity = 100;                
        }
        public void FullCar()
        {
            gasAmount = 100;
        }
        public int GetCapacity()
        {
            return capacity;
        }
        public int GetGasAmount()
        {
            return gasAmount;
        }
        
    }
}
