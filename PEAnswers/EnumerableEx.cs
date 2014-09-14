﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class EnumerableEx
    {
        public static IEnumerable<int> RangeBy(int start, int end, int increment)
        {
            for (int i = start; i <= end; i += increment)
                yield return i;
        }

        public static bool IsPalindrome(this string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        #region Permutations

        public static IEnumerable<IEnumerable<T>> Permutations<T>(this IEnumerable<T> list, bool allowRepeats = false)
        {
            return list.Permutations(list.Count(), allowRepeats);
        }

        public static IEnumerable<IEnumerable<T>> Permutations<T>(this IEnumerable<T> list, int length, bool allowRepeats = false)
        {
            if (allowRepeats)
            {
                return GetPermutationsWithRepeats(list, length);
            }
            else
            {
                return GetPermutations(list, length);
            }
        }

        private static IEnumerable<IEnumerable<T>> GetPermutationsWithRepeats<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });
            return GetPermutationsWithRepeats(list, length - 1)
                .SelectMany(t => list,
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }

        private static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });
            return GetPermutations(list, length - 1)
                .SelectMany(t => list.Where(o => !t.Contains(o)),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }

        #endregion
    }
}
