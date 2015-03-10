using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE025
    {
        public static int Answer()
        {
			return Sequences.FibonacciBig()
				.TakeWhile(f => f.ToString().Length < 1000)
				.Aggregate(1, (i, _) => ++i);
        }
    }
}
