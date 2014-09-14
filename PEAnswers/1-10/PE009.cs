using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE009
    {
        public static int Answer()
        {
            //var pythagoreanTriplets = from a in Enumerable.Range(1, 999)
            //                          from b in Enumerable.Range(1, 999)
            //                          let c = 1000 - a - b
            //                          where a < b && b < c && Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)
            //                          select a * b * c;

            //return pythagoreanTriplets.First();

            for (int a = 1; a <= 999; a++)
            {
                for (int b = a + 1; b <= 999; b++)
                {
                    int c = 1000 - a - b;

                    if ((a * a) + (b * b) == (c * c))
                    {
                        return a * b * c;
                    }
                }
            }

            throw new InvalidOperationException();
        }
    }
}
