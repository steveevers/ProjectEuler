using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE007
    {
        public static long Answer()
        {
            var primes = Sequences.Primes(500000);

            return primes.ElementAt(10000);
        }
    }
}
