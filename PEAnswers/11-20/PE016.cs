using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE016
    {
        public static long Answer()
        {
            return BigInteger
                .Pow(2, 1000)
                .ToString()
                .ToCharArray()
                .Select(c => long.Parse(c.ToString()))
                .Sum();
        }
    }
}
