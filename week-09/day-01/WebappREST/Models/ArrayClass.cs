using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebappREST.Models
{
    public class ArrayClass
    {
        public string What { get; set; }
        public int[] Numbers { get; set; }

        public int Sum()
        {
            int num = 0;

            for (int i = 0; i < Numbers.Length; i++)
            {
                num += Numbers[i];
            }

            return num;
        }
        public int Multiply()
        {
            int num = 1;

            for (int i = 1; i < Numbers.Length; i++)
            {
                num *= Numbers[i];
            }

            return num;
        }

        public int[] Double()
        {
            int[] result = new int[Numbers.Length];

            for (int i = 0; i < Numbers.Length; i++)
            {
                result[i] = Numbers[i] * 2;
            }
            return result;
        }

    }
}
