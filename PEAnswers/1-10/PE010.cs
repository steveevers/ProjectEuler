using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE010
    {
        public static long Answer()
        {
            long sum = 0;
            foreach (var p in Sequences.Primes(2000000))
            {
                sum += p;
            }
            
            return sum;
        }
    }
}
