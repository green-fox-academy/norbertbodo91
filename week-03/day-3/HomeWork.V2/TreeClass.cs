using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Tree
    {
        public string type;
        public string leafcolor;
        public int age;
        public string sex;

        public Tree(string Type,string LeafColor,int Age,string Sex)
        {
            this.type = Type;
            this.leafcolor = LeafColor;
            this.age = Age;
            this.sex = Sex;
        }
        
    }
}
