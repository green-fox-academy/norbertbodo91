using System;
using CounterWebApp.Service;

namespace CounterWebApp.Models
{
    public class NumberCounter : ICountable
    {
        public int Number { get; set; }

        public NumberCounter(int number = 0)
        {
            Number = number;
        }
        public void IncreaseNumber()
        {
            Number++;
        }
    }
}
