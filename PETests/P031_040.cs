using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PETests
{
    [TestClass]
    public class P031_040
    {
        [TestMethod, TestCategory("31-40"), TestCategory("Needs Improvement"), Ignore]
        public void PE034()
        {
            Assert.AreEqual(40730, Performance.Test(PEAnswers.PE034.Answer, TimeSpan.FromSeconds(1.5)));
        }

        [TestMethod, TestCategory("31-40")]
        public void PE035()
        {
            Assert.AreEqual(55, Performance.Test(PEAnswers.PE035.Answer));
        }

        [TestMethod, TestCategory("31-40")]
        public void PE036()
        {
            Assert.AreEqual(872187, Performance.Test(PEAnswers.PE036.Answer));
        }

        [TestMethod, TestCategory("31-40")]
        public void PE039()
        {
            Assert.AreEqual(840, Performance.Test(PEAnswers.PE039.Answer));
        }

        [TestMethod, TestCategory("31-40")]
        public void PE040()
        {
            Assert.AreEqual(210, Performance.Test(PEAnswers.PE040.Answer));
        }
    }
}
