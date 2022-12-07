using NUnit.Framework;
using ProjectEuler.Problem33_DigitCancellingFractions;
using Assert = NUnit.Framework.Assert;

namespace ProjectEuler.Tests.Problem33_DigitCancellingFractions
{
    [TestFixture]
    public class DigitCancellingFractionsTest
    {
        [Test]
        public void TestMethod1()
        {
            var result = DigitCancellingFractions.Main();
            Assert.AreEqual(.01m, result);
        }
    }
}
