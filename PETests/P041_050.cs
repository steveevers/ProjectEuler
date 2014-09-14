using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PETests
{
    [TestClass]
    public class P041_050
    {
        [TestMethod, TestCategory("41-50")]
        public void PE041()
        {
            Assert.AreEqual(7652413, Performance.Test(PEAnswers.PE041.Answer));
        }

        [TestMethod, TestCategory("41-50"), TestCategory("Needs Improvement"), Ignore]
        public void PE043()
        {
            Assert.AreEqual(16695334890, Performance.Test(PEAnswers.PE043.Answer, TimeSpan.MaxValue));
        }
    }
}
