using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE004
    {
        public static int Answer()
        {
            var products = from n1 in Enumerable.Range(100, 899)
                    from n2 in Enumerable.Range(100, 899)
                    select n1 * n2;

            return products
                .Where(n => n == MathEx.Reverse(n))
                .Max();
        }
    }
}
