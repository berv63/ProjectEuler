using NUnit.Framework;
using ProjectEuler.Problem33_DigitCancellingFractions;
using ProjectEuler.Problem34_DigitFactorials;
using Assert = NUnit.Framework.Assert;

namespace ProjectEuler.Tests.Problem34_DigitFactorial
{
    [TestFixture]
    public class DigitFactorialTest
    {
        [Test]
        public void TestMethod1()
        {
            var result = DigitFactorial.Main();
            Assert.AreEqual(40730, result);
        }
    }
}
