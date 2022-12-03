using NUnit.Framework;
using ProjectEuler.Problem17_NumberLetterCounts;
using Assert = NUnit.Framework.Assert;

namespace ProjectEuler.Tests.Problem17_NumberLetterCounts
{
    [TestFixture]
    public class NumberLetterCountsTest
    {
        [Test]
        public void TestMethod1()
        {
            var result = NumberLetterCounts.Main(5);
            Assert.AreEqual(19, result);
        }

        [Test]
        public void TestMethod2()
        {
            var result = NumberLetterCounts.Main(1000, 1);
            Assert.AreEqual(21124, result);
        }
    }
}
