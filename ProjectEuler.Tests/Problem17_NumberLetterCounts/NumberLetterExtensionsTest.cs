using NUnit.Framework;
using ProjectEuler.Problem17_NumberLetterCounts;

namespace ProjectEuler.Tests.Problem17_NumberLetterCounts
{
    [TestFixture]
    public class NumberLetterExtensionsTest
    {
        [Test]
        public void TestMethod1()
        {
            var result = NumberStringExtensions.GetNumberString(342);
            Assert.AreEqual(23, result.Length);
        }

        [Test]
        public void TestMethod2()
        {
            var result = NumberStringExtensions.GetNumberString(115);
            Assert.AreEqual(20, result.Length);
        }
    }
}
