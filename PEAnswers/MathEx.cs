using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class MathEx
    {
        public static IEnumerable<int> PrimeFactors(long n)
        {
            int max = (int)(Math.Sqrt((double)n) + 1);

            return Sequences.Primes(max).Where(p => n % p == 0);
        }

        public static int Reverse(int d)
        {
            int n = d;
            int reverse = 0;

            while (n != 0)
            {
                reverse *= 10;
                reverse += n % 10;
                n /= 10;
            }

            return reverse;
        }

        public static long SquareOfSums(int n)
        {
            var sum = Enumerable.Range(1, n).Sum();

            return sum * sum;
        }

        public static long SumOfSquares(int n)
        {
            return Enumerable
                .Range(1, n)
                .Select(i => i * i)
                .Sum();
        }

        public static IEnumerable<int> Divisors(int n)
        {
            for (int i = 1; i <= (int)(Math.Sqrt(n)); i++)
            {
                if (n % i == 0)
                {
                    yield return i;
                    yield return n / i;
                }
            }
        }

        public static IEnumerable<long> Divisors(long n)
        {
            for (long i = 1; i <= (long)(Math.Sqrt(n)); i++)
            {
                if (n % i == 0)
                {
                    yield return i;
                    yield return n / i;
                }
            }
        }

        public static int Collatz(int n)
        {
            if (n % 2 == 0)
            {
                return n / 2;
            }
            else
            {
                return (3 * n) + 1;
            }
        }
    }
}
