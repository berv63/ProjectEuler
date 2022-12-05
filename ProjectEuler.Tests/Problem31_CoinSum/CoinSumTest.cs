using NUnit.Framework;
using ProjectEuler.Problem31_CoinSum;

namespace ProjectEuler.Tests.Problem31_CoinSum
{
    [TestFixture]
    public class CoinSumTest
    {
        [Test]
        public void TestMethod1()
        {
            var result = CoinSum.Main(2m);
            Assert.AreEqual(73682, result);
        }
    }
}
