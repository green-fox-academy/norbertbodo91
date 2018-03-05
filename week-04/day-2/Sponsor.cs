using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkMarc5
{
    class Sponsor
    {
        private string name;
        private int age;
        private string gender;
        private string company;
        private int hiredStudents;

        public Sponsor(string Name,int Age,string Gender,string Company)
        {
            this.name = Name;
            this.age = Age;
            this.gender = Gender;
            this.company = Company;
            hiredStudents = 0;
        }
        public void Introduce()
        {
            Console.WriteLine("Hi, I'm"+ name+" , a " + age + " year old "+ gender +" who represents "+ company +" and hired "+ hiredStudents +" students so far.");
        }
        public int Hire()
        {
            return hiredStudents++;
        }
        public void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
    }
}
