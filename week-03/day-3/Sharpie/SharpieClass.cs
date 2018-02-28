using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sharpie
    {
        public float inkAmount = 100;
        public float width;
        public string color;

        public Sharpie(string Color,float Width)
        {
            this.width = Width;
            this.color = Color;
        }
        public void Use()
        {
            inkAmount--;
        }
       
    }
}
