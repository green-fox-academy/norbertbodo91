using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkMarc5
{
    class Person
    {
        private string name;
        private int age;
        private string gender;

        public Person(string Name,int Age,string Gender)
        {
            this.name= Name;
            this.age = Age;
            this.gender = Gender;
        }
        public void Introduce()
        {
            Console.WriteLine("Hi, I'm "+name+", "+age+" year old "+gender);
        }
        public void GetGoal()
        {
            Console.WriteLine("My goal is:Live for the moment!");
        }
        
    }
}
