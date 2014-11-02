using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE024
    {
        public static long Answer()
        {
            StringBuilder sb = new StringBuilder();
            var numbers = Enumerable.Range(0, 10).ToList();
            int n = numbers.Count();
            int remaining = 1000000 - 1;
            
            for (int i = 1; i < n; i++)
            {
                int j = remaining / (n - i).Factorial();
                remaining = remaining % (n - i).Factorial();

                sb.Append(numbers[j]);
                numbers.RemoveAt(j);

                if (remaining == 0)
                    break;
            }

            for (int i = 0; i < numbers.Count; i++)
                sb.Append(numbers[i]);

            return long.Parse(sb.ToString());
        }
    }
}
