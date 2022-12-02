using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem17_NumberLetterCounts;
using System.Runtime.InteropServices.ComTypes;

namespace Problem17_NumberLetterCounts_Test
{
    [TestClass]
    public class NumberLetterCountsTest
    {
        private NumberLetterCounts NumberLetterCounts { get; set; }

        [TestInitialize]
        public void Init()
        {
            NumberLetterCounts = new NumberLetterCounts();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var result = NumberLetterCounts.Main(5);
            Assert.AreEqual(19, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = NumberLetterCounts.Main(1000, 1);
            Assert.AreEqual(21124, result);
        }
    }
}
