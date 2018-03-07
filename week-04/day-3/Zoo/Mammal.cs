using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    class Mammal : Animal
    {
        public Mammal(string name) : base(name,25,4,"Boy")
        {
            
        }
        public override string GetName()
        {
            return name;
        }

        public override string WantChild()
        {
            return " want a child from my uterus!"; 
        }
    }
}
