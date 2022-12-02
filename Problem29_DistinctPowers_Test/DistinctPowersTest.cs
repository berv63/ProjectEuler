using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem29_DistinctPowers;

namespace Problem29_DistinctPowers_Test
{
    [TestClass]
    public class DistinctPowersTest
    {
        private DistinctPowers DistinctPowers { get; set; }

        [TestInitialize]
        public void Init()
        {
            DistinctPowers = new DistinctPowers();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var result = DistinctPowers.Main(5, 5);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = DistinctPowers.Main(100, 100);
            Assert.AreEqual(9183, result);
        }
    }
}
