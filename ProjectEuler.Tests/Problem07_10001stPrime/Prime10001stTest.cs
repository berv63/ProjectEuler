using NUnit.Framework;
using ProjectEuler.Problem07_10001stPrime;
using ProjectEuler.Problem17_NumberLetterCounts;
using Assert = NUnit.Framework.Assert;

namespace ProjectEuler.Tests.Problem07_10001stPrime
{
    [TestFixture]
    public class Prime10001stTest
    {
        [Test]
        public void TestMethod1()
        {
            var result = Prime10001st.Main();
            Assert.AreEqual(104743, result);
        }
    }
}
