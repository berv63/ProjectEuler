using NUnit.Framework;
using ProjectEuler.Problem19_CountingSundays;

namespace ProjectEuler.Tests.Problem19_CountingSundays
{
    [TestFixture]
    public class CountingSundaysTest
    {
        [Test]
        public void TestMethod1()
        {
            var result = CountingSundays.GetSundaysOfCentury(20);
            Assert.AreEqual(171, result);
        }
    }
}
