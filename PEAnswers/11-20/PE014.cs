using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE014
    {
        private static List<int> cache = Enumerable.Range(1, 1000000).Select(n => 0).ToList();
        private const int upperBound = 1000000;

        public static long Answer()
        {
            long max = 0;
            int maxIndex = 0;

            for (int i = 1; i < upperBound; i++)
            {
                var k = SequenceLength(i);
                cache[i] = k;

                if (k > max)
                {
                    max = k;
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        private static int SequenceLength(int i)
        {
            long c = i;
            int k = 1;
            while (c != 1 && c >= i)
            {
                if (c % 2 == 0)
                    c = c / 2;
                else
                    c = (c * 3) + 1;

                k++;
            }
            
            cache[i] = k + cache[(int)c];
            return cache[i];
        }
    }
}
