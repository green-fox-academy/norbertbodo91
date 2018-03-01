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
            GasStation Mol = new GasStation();
            Car Suzuki = new Car();

            Mol.Refill(Suzuki);

            Console.WriteLine(Suzuki.GetGasAmount());
           

            Console.ReadLine();
        }  
    }
}

