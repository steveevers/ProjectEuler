using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE021
    {
        public static int Answer()
        {
            var d = Util.Memoize<int, int>(n => MathEx.Divisors(n).Where(i => i != n).Sum());
            var range = Enumerable.Range(1, 9999);
            var amicablePairs = from a in range
                                from b in range
                                where a != b && d(a) == b && d(b) == a
                                select Tuple.Create(a, b);
            
            var amicableNumbers = amicablePairs
                .SelectMany(t => new List<int>() { t.Item1, t.Item2 })
                .Distinct();

            return amicableNumbers.Sum();
        }
    }
}
