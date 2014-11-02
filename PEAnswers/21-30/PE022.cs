using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE022
    {
        public static int Answer()
        {
            var names = File
                .ReadAllLines(@"Data\PE022.txt")
                .Select(l => l.Replace("\"", string.Empty))
                .SelectMany(l => l.Split(','))
                .OrderBy(n => n)
                .ToList();

            int sum = 0;
            for (int i = 1; i <= names.Count(); i++)
            {
                sum += AlphabeticSum(names[i - 1]) * i;
            }

            return sum;
        }

        private static int AlphabeticSum(string name)
        {
            return name.Select(c => ((int)c) - 64).Sum();
        }
    }
}
