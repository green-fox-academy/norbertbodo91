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
            Sharpie Sharp = new Sharpie("Red",50);

            Sharp.Use();

            Console.WriteLine(Sharp.inkAmount);

            Console.Read();
            
        }

    }
}
