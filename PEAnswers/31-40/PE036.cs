using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE036
    {
        public static int Answer()
        {
            return Enumerable
                .Range(1, 1000000)
                .Where(n => n == MathEx.Reverse(n) && Convert.ToString(n, 2).IsPalindrome())
                .Sum();
        }
    }
}
