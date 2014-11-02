using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class NumericExtensions
    {
        public static bool IsDeficient(this int i)
        {
            return MathEx.DivisorsProper(i).Sum() < i;
        }

        public static bool IsPerfect(this int i)
        {
            return MathEx.DivisorsProper(i).Sum() == i;
        }

        public static bool IsAbundant(this int i)
        {
            return MathEx.DivisorsProper(i).Sum() > i;
        }

        #region Pandigital

        public static bool IsPandigital(this int n)
        {
            return n.ToString().IsPandigital();
        }

        private static bool IsPandigital(this string s)
        {
            HashSet<char> cs = new HashSet<char>();

            foreach (var c in s)
            {
                if (!cs.Add(c))
                {
                    return false;
                }
                else
                {
                    var d = int.Parse(c.ToString());
                    if (d <= 0 || d > s.Length)
                        return false;
                }
            }

            return true;
        }

        #endregion

        public static bool IsInteger(this double d)
        {
            return d == Math.Truncate(d);
        }

        public static IEnumerable<int> Digits(this int n)
        {
            return n.ToString().Select(c => (int)Char.GetNumericValue(c));
        }

        public static IEnumerable<int> Digits(this long n)
        {
            foreach (var c in n.ToString())
                yield return int.Parse(c.ToString());
        }

        #region Factorial

        public static IEnumerable<int> Factorials(this IEnumerable<int> list)
        {
            foreach (var i in list)
                yield return i.Factorial();
        }

        public static int Factorial(this int n)
        {
            return MemFac(n);
        }

        private static Func<int, int> MemFac = Util.Memoize<int, int>(factorial);
        private static int factorial(int n)
        {
            if (n == 0)
                return 1;

            if (n <= 2)
                return n;

            return Factorial(n - 1) * n;
        }

        #endregion

        public static IEnumerable<int> Rotations(this int num)
        {
            var digits = num.Digits().ToList();
            for (int i = 0; i < digits.Count; i++)
            {
                StringBuilder sb = new StringBuilder();

                for (int j = i; j < digits.Count; j++)
                    sb.Append(digits[j]);

                for (int k = 0; k < i; k++)
                    sb.Append(digits[k]);

                yield return int.Parse(sb.ToString());
            }

            yield break;
        }

        #region Primes

        private static BitArray primes;

        public static bool IsPrime(this int n)
        {
            if (n <= 1)
                return false;

            if (primes == null || n >= primes.Count)
                NumericExtensions.generatePrimes(n + 1);

            return primes[n];
        }

        private static void generatePrimes(int upper)
        {
            primes = new BitArray(upper + 1, true);
            primes[0] = false;
            primes[1] = false;
            int current = 1;

            do
            {
                current++;
                if (!primes[current])
                    continue;

                primes[current] = true;

                for (int i = current * 2; i < primes.Count - 1; i += current)
                {
                    primes[i] = false;
                }
            } while (current < upper);
        }

        #endregion
    }
}
