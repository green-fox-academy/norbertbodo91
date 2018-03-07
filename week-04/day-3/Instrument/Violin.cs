using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentsExc
{
    class Violin : StringedInstruments
    {
        public Violin() : base(4)
        {
            name = "Violin";
        }
        public Violin(int numberOfStrings) : base(numberOfStrings)
        {
            name = "Violin";
        }

        public override string Play()
        {
            return name + " , a " + numberOfStrings + " stringed instrument that " + Sound();
        }

        public override string Sound()
        {
            return "Screech";
        }
    }
}
