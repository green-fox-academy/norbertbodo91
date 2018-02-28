using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            var fleet = new Fleet();
            fleet.Add(new Thing("Get Milk"));            
            fleet.Add(new Thing("Remove the obstacles"));
            fleet.Add(new Thing("Stand Up"));
            fleet.Add(new Thing("Eat lunch"));
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also
            fleet.List()[3].Complete();
            fleet.List()[2].Complete();
            Printer(fleet.List());
            Console.Read();
        }
        public static void Printer(List<Thing> toPrint)
        {
            foreach (var listLine  in toPrint)
            {
            if (listLine.IsitCompleted())
            {
                Console.WriteLine("[x]"+ listLine.ThisName());
            }
                else
                {
                    Console.WriteLine("[ ]" + listLine.ThisName());
                }

            }
        }
    }
}
