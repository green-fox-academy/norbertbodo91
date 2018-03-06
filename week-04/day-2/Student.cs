using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkMarc5
{
    class Student : Person
    {
       
         string previousOrganization;
         int skippedDays;
        
        public Student(string name, int age, string gender, string PreviousOrganization) : base(name,age,gender)
        {        
            this.previousOrganization = PreviousOrganization;
            skippedDays = 0;
        }
        public Student()
        {       
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }
        public override string Introduce()
        {
           return base.Introduce() + " year old " + gender + " from " + previousOrganization + " who skipped " + skippedDays + " days from the course already.";
        }
        public override string GetGoal()
        {
            return base.GetGoal() + " Be a junior software developer.";
        }
        public void SkipDays(int numberOfDays)
        {
           skippedDays += numberOfDays;
        }

    }
}
