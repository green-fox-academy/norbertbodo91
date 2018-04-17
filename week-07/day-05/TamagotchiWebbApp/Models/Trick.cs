using System;
namespace TamagotchiWebbApp.Models
{
    public class Trick
    {
        public string image;
        public string description;

        public Trick(string image, string description)
        {
            this.image = image;
            this.description = description;
        }
    }
}
