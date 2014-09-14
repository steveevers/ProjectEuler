using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE017
    {
        public static long Answer()
        {
            return Enumerable
                .Range(1, 1000)
                .Select(n => ToWords(n))
                .SelectMany(w => w.Replace(" ", string.Empty).Replace("-", string.Empty).ToCharArray())
                .Count();
        }

        public static string ToWords(long number)
        {
            StringBuilder sb = new StringBuilder();
            var digits = number.Digits().Reverse().ToList();

            if (number < 10)
                return rest[(int)number];

            for (int i = digits.Count() - 1; i > 0; i--)
            {
                // thousands/millions/billions
                if (i % 3 == 0)
                {
                    bool test = true;
                    for (int j = i + 1; j < i + 2; j++)
                    {
                        if (j > digits.Count() - 1)
                            break;

                        if (digits[j] > 0)
                        {
                            test = false;
                            break;
                        }
                    }

                    if (test)
                        sb.Append(rest[digits[i]]).Append(" ");

                    for (int j = i; j < i + 2; j++)
                    {
                        if (digits[j] > 0)
                        {
                            sb.Append(digitsBeyondTen[i]);
                            break;
                        }
                    }
                }
                // hundred
                else if ((i - 2) % 3 == 0)
                {
                    if (digits[i] > 0)
                    {
                        sb.Append(rest[digits[i]]).Append(" hundred ");
                    }
                }
                // tens and ones
                else if ((i - 1) % 3 == 0)
                {
                    var n = digits[i] * 10 + digits[i - 1];
                    if (i < 2 && digits.Count() > 2 && (digits[i] > 0 || digits[i - 1] > 0))
                        sb.Append("and ");

                    if (n > 0)
                    {
                        if (10 < n && n < 20)
                        {
                            sb.Append(rest[n]).Append(" ");
                        }
                        else
                        {
                            var tens = rest[((int)(n / 10)) * 10];
                            if (tens.Length > 0)
                                sb.Append(tens).Append(" ");

                            sb.Append(rest[n % 10]).Append(" ");
                        }
                    }
                }
            }

            return sb.ToString();
        }

        private static Dictionary<int, string> rest = new Dictionary<int, string>()
        {
            { 0, string.Empty }, 
            { 1, "one" }, 
            { 2, "two" }, 
            { 3, "three" }, 
            { 4, "four" }, 
            { 5, "five" }, 
            { 6, "six" }, 
            { 7, "seven" }, 
            { 8, "eight" }, 
            { 9, "nine" }, 
            { 10, "ten" }, 
            { 11, "eleven" }, 
            { 12, "twelve"}, 
            { 13, "thirteen"}, 
            { 14, "fourteen"}, 
            { 15, "fifteen"}, 
            { 16, "sixteen"}, 
            { 17, "seventeen"}, 
            { 18, "eighteen"}, 
            { 19, "nineteen"}, 
            { 20, "twenty"}, 
            { 30, "thirty"}, 
            { 40, "forty"}, 
            { 50, "fifty"}, 
            { 60, "sixty"}, 
            { 70, "seventy"}, 
            { 80, "eighty"}, 
            { 90, "ninety"}
        };

        private static Dictionary<long, string> digitsBeyondTen = new Dictionary<long, string>()
        {
            { 3, "thousand " }, 
            { 6, "million " }, 
            { 9, "billion " }, 
            { 12, "trillion " }
        };
    }
}
