using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem19_CountingSundays;

namespace Problem19_CountingSundays_Test
{
    [TestClass]
    public class CountingSundaysTest
    {
        private CountingSundays CountingSundays { get; set; }

        [TestInitialize]
        public void Init()
        {
            CountingSundays = new CountingSundays();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var result = CountingSundays.GetSundaysOfCentury(20);
            Assert.AreEqual(171, result);
        }
    }
}
