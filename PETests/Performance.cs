using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETests
{
    public static class Performance
    {
        public static T Test<T>(Func<T> answer, TimeSpan boundary)
        {
            var perfTest = new Stopwatch();
            perfTest.Start();
            var result = answer();
            perfTest.Stop();

            if (perfTest.Elapsed > boundary)
            {
                Assert.Fail(string.Format("Performance requirement failed. {0} > {1}", perfTest.Elapsed, boundary));
            }

            return result;
        }

        public static T Test<T>(Func<T> answer)
        {
            return Test(answer, TimeSpan.FromSeconds(1));
        }
    }
}
