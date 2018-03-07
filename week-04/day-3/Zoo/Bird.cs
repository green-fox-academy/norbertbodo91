using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    class Bird : Animal
    {
        public Bird(string name) : base(name,39,2,"Girl")
        {

        }
        public override string GetName()
        {
            return name;
        }

        public override string WantChild()
        {
            return "want a child from an egg!";
        }
    }
}
