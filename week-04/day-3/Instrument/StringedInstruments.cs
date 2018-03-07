using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentsExc
{
    abstract class StringedInstruments : Instrument
    {
        protected int numberOfStrings;

        public StringedInstruments(int numberOfStrings)
        {
            this.numberOfStrings = numberOfStrings;
        }

        public abstract string Sound();
      
    }
}
