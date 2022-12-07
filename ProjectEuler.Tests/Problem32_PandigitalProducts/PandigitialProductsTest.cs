using NUnit.Framework;
using ProjectEuler.Problem27_QuadraticPrimes;
using ProjectEuler.Problem32_PandigitalProducts;
using Assert = NUnit.Framework.Assert;

namespace ProjectEuler.Tests.Problem32_PandigitalProducts
{
    [TestFixture]
    public class PandigitalProductsTest
    {
        [Test]
        public void TestMethod1()
        {
            var result = PandigitalProducts.Main();
            Assert.AreNotEqual(342748, result);
            Assert.AreNotEqual(14804, result);
            Assert.AreEqual(45228, result);
        }
    }
}
