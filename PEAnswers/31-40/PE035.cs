using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE035
    {
        public static int Answer()
        {
            return Sequences
                .Primes(1000000)
                .Reverse() // reverse causes IsPrime to check larger numbers first, so that we don't re-sieve constantly
                .Where(p => p.Rotations().Distinct().All(r => r.IsPrime()))
                .Count();
                
        }
    }
}
