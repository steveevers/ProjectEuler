using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE034
    {
        public static int Answer()
        {
            return Enumerable
                .Range(3, (7 * 9.Factorial()) - 2)
                .AsParallel()
                .Where(n => n.Digits().Factorials().Sum().Equals(n))
                .Sum();
        }
    }
}
