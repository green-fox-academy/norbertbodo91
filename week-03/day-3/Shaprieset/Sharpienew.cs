using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Sharpie
    {
        private float inkAmount;
        private float width;
        private string color;

        public Sharpie(string Color, float Width)
        {
            this.width = Width;
            this.color = Color;
            this.inkAmount = 5;
        }
        public void Use()
        {
            if (width > 5)
            {
                 inkAmount = inkAmount - 5;
            }
            else
            {
                 inkAmount = inkAmount - 2;
            }
        }
        public float GetInk()
        {
            return inkAmount;
        }

    }
}

