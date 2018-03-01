using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class GasStation
    {
        private int gasAmount = 500;

        public void Refill(Car car)
        {
            car.FullCar();
            gasAmount = gasAmount - car.GetCapacity();
        }
      
    }
}
