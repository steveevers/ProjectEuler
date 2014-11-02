using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PEAnswers;

namespace PETests
{
    [TestClass]
    public class MathEx
    {
        [TestMethod, TestCategory("Dependencies")]
        public void AbundantNumbers()
        {
            for (int i = 1; i < 12; i++)
            {
                Assert.IsFalse(i.IsAbundant(), i + " is abundant, and shouldn't be.");
            }

            Assert.IsTrue(12.IsAbundant());
        }
    }
}
