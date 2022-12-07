using NUnit.Framework;
using ProjectEuler.Problem35_CircularPrimes;
using Assert = NUnit.Framework.Assert;

namespace ProjectEuler.Tests.Problem35_CircularPrimes
{
    [TestFixture]
    public class CircularPrimesTest
    {
        [Test]
        public void TestMethod1()
        {
            var result = CircularPrimes.Main(99);
            Assert.AreEqual(13, result);
        }
        
        [Test]
        public void TestMethod2()
        {
            var result = CircularPrimes.Main(999999);
            Assert.AreEqual(55, result);
        }
    }
}
