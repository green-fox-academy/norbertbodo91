using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    class Reptile : Animal
    {
        public Reptile(string name) : base(name,125,4,"Girl")
        {

        }
        public override string GetName()
        {
            return name;
        }
        public override string WantChild()
        {
            if (name == "frog")
            {
                return "want child from a magic way!";
            }
            else
            {
                return "want a child from an egg!";
            }
        }
    }
}
