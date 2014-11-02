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
            var permutations = 9876543210
                .Digits()
                .Permutations()
                .Select(p => string.Join(string.Empty, p));

            return permutations
                .AsParallel()
                .Where(n => HasSSDivProperty(n))
                .Select(n => long.Parse(n))
                .Sum();
        }

        private static List<int> primes = Sequences.Primes(20).Take(7).ToList();
        public static bool HasSSDivProperty(string s)
        {
            var index = 0;

            for (int i = 1; i <= s.Length - 3; i++)
            {
                var n = int.Parse(s.Substring(i, 3));
                if (n % primes[index] != 0)
                    return false;

                index++;
            }

            return true;
        }
    }
}
