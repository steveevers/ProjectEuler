using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE028
    {
        public static int Answer()
        {
            double x = 1;

            for (int n = 3; n <= 1001; n += 2)
            {
                x += n * n;
                x += (n * n) - (n - 1);
                x += (n * n) - (2 * (n - 1));
                x += (n * n) - (3 * (n - 1));
            }

            var result = EnumerableEx.RangeBy(3, 1001, 2)
                            .Aggregate(
                            1,
                            (a, n) =>
                            {
                                a += n * n;
                                a += (n * n) - (n - 1);
                                a += (n * n) - (2 * (n - 1));
                                a += (n * n) - (3 * (n - 1));

                                return a;
                            });

            return result;
        }
    }
}
