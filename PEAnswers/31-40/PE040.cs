using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE040
    {
        public static int Answer()
        {
            int answer = 1;
            int index = 0;
            int nextIndex = 1;
            foreach (var c in IrrationalDecimalFraction())
            {
                index++;
                if (index == nextIndex)
                {
                    answer *= int.Parse(c.ToString());
                    nextIndex *= 10;
                }

                if (index >= 1000000)
                {
                    break;
                }
            }

            return answer;
        }

        public static IEnumerable<char> IrrationalDecimalFraction()
        {
            int i = 0;
            do
            {
                i++;
                foreach (var c in i.ToString())
                {
                    yield return c;
                }
            } while (true);
        }
    }
}
