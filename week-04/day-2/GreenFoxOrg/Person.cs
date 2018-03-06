using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkMarc5
{
    class Person
    {
         protected string name;
         protected int age;
         protected string gender;

        public Person(string Name,int Age,string Gender)
        {
            this.name= Name;
            this.age = Age;
            this.gender = Gender;
        }
        public Person()
        {
            this.name = "Jane Doe";
            this.age = 30;
            this.gender = "female";
        }
        public virtual string Introduce()
        {
           return  "Hi, I'm "+name+", "+age+" year old "+gender;
        }
        public virtual string GetGoal()
        {
            return "My goal is:Live for the moment!";
        }
        
    }
}
