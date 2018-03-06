using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkMarc5
{
    class Mentor : Person
    {
         
         string level;

        public Mentor(string name, int age, string gender, string Level) :base(name,age,gender)
        {
          
            this.level = Level;
        }
        public Mentor()
        {
            level = "intermediate";
        }
        public override string GetGoal()
        {
            return base.GetGoal() + " Educate brilliant junior software developers";
        }
        public override string Introduce()
        {
            return base.Introduce() + " "+level+" mentor.";
        }

    }
}
