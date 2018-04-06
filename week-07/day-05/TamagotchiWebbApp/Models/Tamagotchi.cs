using System;
using System.Collections.Generic;

namespace TamagotchiWebbApp.Models
{
    public class Tamagotchi : ITamagochi
    {
        public string name;
        public string food;
        public string drink;
        public string image;

        public List<Trick> trickList = new List<Trick>
        {
            new Trick("http://78.media.tumblr.com/aa8c1400c9e563afa22bcb63fae59960/tumblr_nwuqg9UMsH1rpduwho1_500.gif","Dance"),
            new Trick("http://bestanimations.com/Humans/Skeletons/skeleton-animated-gif-7.gif","Dance with a friend"),
            new Trick("http://bestanimations.com/Humans/Skeletons/skeleton-animated-gif-12.gif","Dance with a group"),
            new Trick("https://media1.tenor.com/images/08db7c2738295b221067ed1f9e633bc1/tenor.gif?itemid=8911309","Eat some delicious 'smoked Bones'"),
            new Trick("https://i.pinimg.com/originals/34/a7/90/34a7907d5bdc62899416b92edabf6251.gif","drink some soul Beer"),
            new Trick("http://bestanimations.com/Humans/Skeletons/skeleton-animated-gif-13.gif","have a bath"),
            new Trick("http://78.media.tumblr.com/b231bfade40b7c40488c4653c7368da0/tumblr_miqpbkqfLw1qh0oz4o1_500.gif","play music on your friend"),
            new Trick("https://i.makeagif.com/media/8-25-2015/b_X_WS.gif","have a training with your friend")

        };

        public Tamagotchi(string name = "", string food = "bones", string drink = "souls", string image = "https://thumbs.gfycat.com/BeneficialWhisperedLamprey-max-1mb.gif")
        {
            this.name = name;
            this.food = food;
            this.drink = drink;
            this.image = image;
        }
        public void DoTrick(int numberOfTrick)
        {
            image = trickList[numberOfTrick].image;
        }
        public void SetName(string givenName)
        {
            name = givenName;
        }
    }
}
