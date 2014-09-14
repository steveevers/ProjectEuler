using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE029
    {
        public static int Answer()
        {
            return (from a in Enumerable.Range(2, 99) 
                    from b in Enumerable.Range(2, 99)
                    select Math.Pow(a, b))
                    .Distinct()
                    .Count();
        }
    }
}
