using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PETests
{
    [TestClass]
    public class P021_030
    {
        [TestMethod, TestCategory("21-30")]
        public void PE021()
        {
            Assert.AreEqual(31626, Performance.Test(PEAnswers.PE021.Answer));
        }

        [TestMethod, TestCategory("21-30")]
        public void PE022()
        {
            Assert.AreEqual(871198282, Performance.Test(PEAnswers.PE022.Answer));
        }

        [TestMethod, TestCategory("21-30")]
        public void PE023()
        {
            Assert.AreEqual(4179871, Performance.Test(PEAnswers.PE023.Answer));
        }

        [TestMethod, TestCategory("21-30")]
        public void PE024()
        {
            Assert.AreEqual(2783915460, Performance.Test(PEAnswers.PE024.Answer));
        }

        [TestMethod, TestCategory("21-30")]
        public void PE025()
        {
            Assert.AreEqual(4782, Performance.Test(PEAnswers.PE025.Answer));
        }

        [TestMethod, TestCategory("21-30")]
        public void PE028()
        {
            Assert.AreEqual(669171001, Performance.Test(PEAnswers.PE028.Answer));
        }

        [TestMethod, TestCategory("21-30")]
        public void PE029()
        {
            Assert.AreEqual(9183, Performance.Test(PEAnswers.PE029.Answer));
        }

        [TestMethod, TestCategory("21-30")]
        public void PE030()
        {
            Assert.AreEqual(443839, Performance.Test(PEAnswers.PE030.Answer));
        }
    }
}
