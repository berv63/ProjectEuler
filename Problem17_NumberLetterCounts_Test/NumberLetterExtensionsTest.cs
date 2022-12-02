using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem17_NumberLetterCounts;
using System.Runtime.InteropServices.ComTypes;

namespace Problem17_NumberLetterCounts_Test
{
    [TestClass]
    public class NumberLetterExtensionsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = NumberStringExtensions.GetNumberString(342);
            Assert.AreEqual(23, result.Length);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = NumberStringExtensions.GetNumberString(115);
            Assert.AreEqual(20, result.Length);
        }
    }
}
