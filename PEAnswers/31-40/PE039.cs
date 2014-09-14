using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE039
    {
        public static int Answer()
        {
            var results = from a in Enumerable.Range(1, 998)
                          from b in Enumerable.Range(1, 998)
                          let c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))
                          where c.IsInteger()
                          let p = a + b + (int)c 
                          where p <= 1000
                          select p;

            return results
                .GroupBy(i => i)
                .OrderByDescending(grp => grp.Count())
                .First()
                .Key;
        }
    }
}
