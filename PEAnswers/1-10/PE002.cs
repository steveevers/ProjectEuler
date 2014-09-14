using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE002
    {
        public static long Answer()
        {
            long result = Sequences
                .Fibonacci(1, 2)
                .TakeWhile(f => f <= 4000000)
                .Where(i => i % 2 == 0)
                .Sum();

            return result;
        }
    }
}
