using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE003
    {
        public static long Answer()
        {
            long n = 600851475143;

            return MathEx.PrimeFactors(n).Max();
        }
    }
}
