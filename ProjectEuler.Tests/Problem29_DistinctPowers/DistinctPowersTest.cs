using NUnit.Framework;
using ProjectEuler.Problem29_DistinctPowers;

namespace ProjectEuler.Tests.Problem29_DistinctPowers
{
    [TestFixture]
    public class DistinctPowersTest
    {
        [Test]
        public void TestMethod1()
        {
            var result = DistinctPowers.Main(5, 5);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void TestMethod2()
        {
            var result = DistinctPowers.Main(100, 100);
            Assert.AreEqual(9183, result);
        }
    }
}
