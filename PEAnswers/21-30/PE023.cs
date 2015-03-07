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

            var range = Enumerable.Range(1, max).ToList();
            var abundantNumbers = range.Where(i => i.IsAbundant()).ToList();
            var abundantSums = new HashSet<int>();
            abundantSums.AddRange(from a in abundantNumbers
                                  from b in abundantNumbers
                                  select a + b);

            return range
                .Where(i => !abundantSums.Contains(i))
                .Sum();
        }
    }
}
