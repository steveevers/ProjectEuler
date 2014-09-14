using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE043
    {
        public static long Answer()
        {
            var numbers = 9876543210
                .Digits()
                .Permutations()
                .Select(p => string.Join(string.Empty, p))
                .Where(n => HasSSDivProperty(n));

            long l = 0;
            foreach (var n in numbers)
            {
                l += long.Parse(n);
            }

            return l;
        }

        public static bool HasSSDivProperty(string s)
        {
            var primes = Sequences.Primes(20).Take(7);
            var index = 0;

            for (int i = 1; i <= s.Length - 3; i++)
            {
                var n = int.Parse(s.Substring(i, 3));
                if (n % primes.ElementAt(index) != 0)
                    return false;

                index++;
            }

            return true;
        }
    }
}
