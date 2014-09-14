using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE005
    {
        public static int Answer()
        {
            for (int i = 20; i <= int.MaxValue; i += 20)
            {
                bool found = true;

                for (int j = 19; j >= 1; j--)
                {
                    if (i % j != 0)
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                    return i;
            }

            throw new InvalidOperationException();
        }
    }
}
