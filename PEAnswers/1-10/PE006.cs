using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE006
    {
        public static long Answer()
        {
            return MathEx.SquareOfSums(100) - MathEx.SumOfSquares(100);
        }
    }
}
