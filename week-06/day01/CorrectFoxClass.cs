using System;
using System.Collections.Generic;
using System.Text;

namespace LinQ
{
    class Fox
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public Fox(string name = "No Name",string type = "No Type",string color = "No Color")
        {
            name = Name;
            type = Type;
            color = Color;
        }
    }
}
