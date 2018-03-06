using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkMarc5
{
    class Sponsor : Person
    {
        
         string company;
         int hiredStudents;

        public Sponsor(string name,int age,string gender,string Company) :base(name,age,gender)
        {           
            this.company = Company;
            
        }
        public Sponsor()
        {      
            company = "Google";
            hiredStudents = 0;
        }
        public override string Introduce()
        {
            return base.Introduce() +" who represents "+ company +" and hired "+ hiredStudents +" students so far.";
        }
        public void Hire()
        {
            hiredStudents++;
        }
        public override string GetGoal()
        {
           return base.GetGoal() + " Hire brilliant junior software developers.";
        }
    }
}
