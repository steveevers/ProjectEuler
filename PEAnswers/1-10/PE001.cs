using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE001
    {
        public static int Answer()
        {
            var num = Enumerable.Range(1, 999)
                .Where(i => i % 3 == 0 || i % 5 == 0)
                .Sum();

            return num;
        }
    }
}
