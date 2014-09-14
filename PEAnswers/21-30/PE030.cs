using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE030
    {
        public static int Answer()
        {
            return Enumerable
                .Range(2, 354294)
                .AsParallel()
                .Where(n => n.Digits().Select(x => Math.Pow(x, 5)).Sum() == n)
                .Sum();
        }
    }
}
