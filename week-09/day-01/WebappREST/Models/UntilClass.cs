using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebappREST.Models
{
    public class UntilClass
    {
        public int? Until { get; set; }

        public int Sum()
        {
            int num = 0;
            for (int i = 0; i <= Until; i++)
            {
                num += i;
            }
            return num;
        }

        public int Factor()
        {
            int num = 1;

            for (int i = 1; i <= Until; i++)
            {
                num *= i;
            }

            return num;
        }
    }
}
