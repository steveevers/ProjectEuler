using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE041
    {
        public static int Answer()
        {
            // start with a large number so that primes are generated once
            return 7654321
                .Digits()
                .Permutations()
                .Select(list => int.Parse(string.Join(string.Empty, list)))
                .Where(n => n.IsPandigital() && n.IsPrime())
                .Aggregate(0, (a, i) => a = i > a ? i : a);
        }
    }
}
