using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class Sequences
    {
        public static IEnumerable<int> Primes(int max)
        {
            BitArray primes = new BitArray(max + 1, true);
            primes[0] = false;
            primes[1] = true;

            for (int i = 2; i <= max; i++)
            {
                if (primes[i])
                {
                    yield return i;
                    for (int j = i + i; j <= max; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }
        }

        public static IEnumerable<BigInteger> FibonacciBig()
        {
            BigInteger a = 1;
            BigInteger b = 1;

            do
            {
                yield return a;
                BigInteger c = a + b;
                a = b;
                b = c;
            } while (true);
        }

        public static IEnumerable<long> Fibonacci(long a = 1, long b = 1)
        {
            do
            {
                yield return a;
                long c = a + b;
                a = b;
                b = c;
            } while (true);
        }

        public static IEnumerable<int> Collatz(int n)
        {
            int c = n;
            yield return c;

            do
            {
                c = MathEx.Collatz(c);
                yield return c;
            } while (c != 1);
        }
    }
}
