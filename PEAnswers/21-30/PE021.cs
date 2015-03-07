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
            var amicableNumbers = new HashSet<int>();
            int max = 9999;

            for (int a = 1; a <= max; a++)
            {
                for (int b = a; b <= max; b++)
                {
                    if (a != b && d(a) == b && d(b) == a)
                    {
                        amicableNumbers.Add(a);
                        amicableNumbers.Add(b);
                    }
                }
            }

            return amicableNumbers.Sum();
        }
    }
}
