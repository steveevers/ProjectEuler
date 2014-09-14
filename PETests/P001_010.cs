using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PETests
{
    [TestClass]
    public class PE001_010
    {
        [TestMethod, TestCategory("1-10")]
        public void PE001()
        {
            Assert.AreEqual(233168, Performance.Test(PEAnswers.PE001.Answer));
        }

        [TestMethod, TestCategory("1-10")]
        public void PE002()
        {
            Assert.AreEqual(4613732, Performance.Test(PEAnswers.PE002.Answer));
        }

        [TestMethod, TestCategory("1-10")]
        public void PE003()
        {
            Assert.AreEqual(6857, Performance.Test(PEAnswers.PE003.Answer));
        }

        [TestMethod, TestCategory("1-10")]
        public void PE004()
        {
            Assert.AreEqual(906609, Performance.Test(PEAnswers.PE004.Answer));
        }

        [TestMethod, TestCategory("1-10")]
        public void PE005()
        {
            Assert.AreEqual(232792560, Performance.Test(PEAnswers.PE005.Answer));
        }

        [TestMethod, TestCategory("1-10")]
        public void PE006()
        {
            Assert.AreEqual(25164150, Performance.Test(PEAnswers.PE006.Answer));
        }

        [TestMethod, TestCategory("1-10")]
        public void PE007()
        {
            Assert.AreEqual(104743, Performance.Test(PEAnswers.PE007.Answer));
        }

        [TestMethod, TestCategory("1-10")]
        public void PE008()
        {
            Assert.AreEqual(23514624000, Performance.Test(PEAnswers.PE008.Answer));
        }

        [TestMethod, TestCategory("1-10")]
        public void PE009()
        {
            Assert.AreEqual(31875000, Performance.Test(PEAnswers.PE009.Answer));
        }

        [TestMethod, TestCategory("1-10")]
        public void PE010()
        {
            Assert.AreEqual(142913828922, Performance.Test(PEAnswers.PE010.Answer));
        }
    }
}
