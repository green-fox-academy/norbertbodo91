using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumProg
{
    public class SumClass
    {
     public int? SumMyNms(List<int> numList)
        {
            if (numList == null)
            {
                return null;
            }
        return numList.Sum();
        }

    }
}

