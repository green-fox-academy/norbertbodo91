using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class SharpieSet
    {
        public List<Sharpie> Sharpies;

        public SharpieSet()
        {
            Sharpies = new List<Sharpie>();
        }
        public void Add(Sharpie sharpie)
        {
            Sharpies.Add(sharpie);
        }
        public void RemoveUnusable()
        {
            List<Sharpie> Sharpienew = new List<Sharpie>();

            foreach (var sharp in Sharpies)
            {
                if (sharp.GetInk() != 0)
                {
                    Sharpienew.Add(sharp);
                }
            }
            Sharpies = Sharpienew;
        }
        public int CountUsable()
        {
            int sumSharpie= 0;
            foreach (var sharp in Sharpies)
            {
                if (sharp.GetInk() > 0)
                {
                    sumSharpie++;
                }
            }
         return sumSharpie;
        }
    }
}
