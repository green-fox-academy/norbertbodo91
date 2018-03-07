using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkMarc5
{
    class Program
    {
        static void Main(string[] args)
        {

            var jozsi = new Student();
           
            var JozsiClone = (Student)jozsi.Clone();

            Console.WriteLine(JozsiClone.Introduce());

            Console.ReadLine();
        }
    }
}
