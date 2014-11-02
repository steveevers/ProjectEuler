using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE023
    {
        public static int Answer()
        {
            int max = 28123;

            var abundantNumbers = Enumerable.Range(1, max).Where(i => i.IsAbundant()).ToList();
            var abundantSums = from a in abundantNumbers
                               from b in abundantNumbers
                               select a + b;

            return Enumerable.Range(1, max).Except(abundantSums).Sum();
        }
    }
}
