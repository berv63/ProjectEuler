using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem78_CoinPartitions;

namespace Problem78_CoinPartitions_Test
{
    [TestClass]
    public class CoinPartitionsTest
    {
        private CoinPartitions CoinPartitions { get; set; }

        [TestInitialize]
        public void Init()
        {
            CoinPartitions = new CoinPartitions();
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
