using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE012
    {
        public static long Answer()
        {
            return TriangleNumbers()
                .SkipWhile(n => MathEx.Divisors(n).Count() <= 500)
                .Take(1)
                .First();
        }

        public static IEnumerable<long> TriangleNumbers()
        {
            return TriangleNumbers(1, 0);
        }

        public static IEnumerable<long> TriangleNumbers(int i, int n)
        {
            do
            {
                n = i + n;
                yield return n;
                i++;
            } while (true);
        }
    }
}
