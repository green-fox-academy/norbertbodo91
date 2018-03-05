using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkMarc5
{
    class Student
    {
        private string name;
        private int age;
        private string gender;
        private string previousOrganization;
        private int skippedDays;
        

        public Student(string Name, int Age, string Gender, string PreviousOrganization)
        {
            this.name = Name;
            this.age = Age;
            this.gender = Gender;
            this.previousOrganization = PreviousOrganization;
            skippedDays = 0;
        }
        public void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", " + age + " year old " + gender + " from " + previousOrganization + " who skipped " + skippedDays + " days from the course already.");
        }
        public void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }
        public int SkipDays(int numberOfDays)
        {
           return skippedDays = skippedDays + numberOfDays;
        }

    }
}
