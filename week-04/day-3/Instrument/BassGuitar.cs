using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentsExc
{
    class BassGuitar : StringedInstruments
    {
        public BassGuitar() : base(4)
        {
            name = "BassGuitar";
        }
        public BassGuitar(int numberOfStrings) : base(numberOfStrings)
        {
            name = "BassGuitar";
        }
        public override string Play()
        {
           return name + " , a " + numberOfStrings + " stringed instrument that " + Sound();
        }

        public override string Sound()
        {
            return "Duum-duum-duum";
        }
    }
}
