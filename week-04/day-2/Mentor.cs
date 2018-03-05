using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkMarc5
{
    class Mentor
    {
        private string name;
        private int age;
        private string gender;
        private string level;

        public Mentor(string Name, int Age, string Gender, string Level)
        {
            this.name = Name;
            this.age = Age;
            this.gender = Gender;
            this.level = Level;
        }
        public void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers");
        }
        public void Introduce()
        {
            Console.WriteLine("Hi, I'm "+name+", "+age+" year old "+gender+" "+level+" mentor.");
        }

    }
}
