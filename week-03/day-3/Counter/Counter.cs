using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Counter
    {
        public int count;
        public string get;
        
       
       public Counter(int Count)
        {
            this.count = Count;
        }
        public void Add()
        {
            count++;
        }
        public void Add(int AddCount)
        {
            count += AddCount;
        }
        public void reset()
        {
            count.ToString();                
        }
        public void Reset()
        {
            count=0;
        }
    }
}
