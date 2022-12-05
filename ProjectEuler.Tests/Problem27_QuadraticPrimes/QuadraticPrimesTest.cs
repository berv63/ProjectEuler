using NUnit.Framework;
using ProjectEuler.Problem27_QuadraticPrimes;
using Assert = NUnit.Framework.Assert;

namespace ProjectEuler.Tests.Problem27_QuadraticPrimes
{
    [TestFixture]
    public class QuadraticPrimesTest
    {
        [Test]
        public void TestMethod1()
        {
            var result = QuadraticPrimes.Main(1, 1, 41, 41, false);
            Assert.AreEqual(40, result);
        }
        
        [Test]
        public void TestMethod2()
        {
            var result = QuadraticPrimes.Main(-79, -79, 1601, 1601, false);
            Assert.AreEqual(80, result);
        }
        
        [Test]
        public void TestMethod3()
        {
            var result = QuadraticPrimes.Main(-999, 999, -999, 999, true);
            Assert.AreEqual(-59231, result);
        }
    }
}
