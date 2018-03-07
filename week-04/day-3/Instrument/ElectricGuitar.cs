using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentsExc
{
    class ElectricGuitar : StringedInstruments
    {
        public ElectricGuitar() : base(6)
        {
            name = "Electric Guitar";
        }
        public ElectricGuitar(int numberOfStrings) : base(numberOfStrings)
        {
            name = "Electric Guitar";
        }
        public override string Play()
        {
            return name + " , a " + numberOfStrings + " stringed instrument that " + Sound();
        }

        public override string Sound()
        {
           return "Twang";
        }
    }
}
