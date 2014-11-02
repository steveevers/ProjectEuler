using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace PETests
{
    [TestClass]
    public class P011_020
    {
        [TestMethod, TestCategory("11-20")]
        public void PE011()
        {
            Assert.AreEqual(70600674, Performance.Test(PEAnswers.PE011.Answer));
        }

        [TestMethod, TestCategory("11-20")]
        public void PE012()
        {
            Assert.AreEqual(76576500, Performance.Test(PEAnswers.PE012.Answer));
        }

        [TestMethod, TestCategory("11-20")]
        public void PE013()
        {
            Assert.AreEqual("5537376230", Performance.Test(PEAnswers.PE013.Answer));
        }

        [TestMethod, TestCategory("11-20")]
        public void PE014()
        {
            Assert.AreEqual(837799, Performance.Test(PEAnswers.PE014.Answer));
        }

        [TestMethod, TestCategory("11-20")]
        public void PE015()
        {
            Assert.AreEqual(137846528820, Performance.Test(PEAnswers.PE015.Answer));
        }

        [TestMethod, TestCategory("11-20")]
        public void PE016()
        {
            Assert.AreEqual(1366, Performance.Test(PEAnswers.PE016.Answer));
        }

        [TestMethod, TestCategory("11-20")]
        public void PE017()
        {
            Assert.AreEqual(21124, Performance.Test(PEAnswers.PE017.Answer));
        }

        [TestMethod, TestCategory("11-20")]
        public void PE018()
        {
            Assert.AreEqual(1074, Performance.Test(PEAnswers.PE018.Answer));
        }

        [TestMethod, TestCategory("11-20")]
        public void PE019()
        {
            Assert.AreEqual(0, Performance.Test(PEAnswers.PE019.Answer));
        }

        [TestMethod, TestCategory("11-20")]
        public void PE020()
        {
            Assert.AreEqual(0, Performance.Test(PEAnswers.PE020.Answer));
        }
    }
}
