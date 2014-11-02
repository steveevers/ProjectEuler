using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE025
    {
        public static int Answer()
        {
            int index = 0;

            foreach (var f in Sequences.FibonacciBig())
            {
                index++;
                if (f.ToString().Length >= 1000)
                    break;
            }

            return index;
        }
    }
}
