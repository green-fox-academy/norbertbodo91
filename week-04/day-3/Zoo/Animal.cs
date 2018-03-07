using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    abstract class Animal
    {
        protected int age;
        protected string name;
        protected int legs;
        protected string gender;

        public Animal(string name, int age, int legs, string gender)
        {
            this.name = name;
            this.age = age;
            this.legs = legs;
            this.gender = gender;
        }

        public abstract string GetName();
        public abstract string WantChild();
    }
}
