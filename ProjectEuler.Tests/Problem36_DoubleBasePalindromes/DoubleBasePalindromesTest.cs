using NUnit.Framework;
using ProjectEuler.Problem35_CircularPrimes;
using ProjectEuler.Problem36_DoubleBasePalindromes;
using Assert = NUnit.Framework.Assert;

namespace ProjectEuler.Tests.Problem36_DoubleBasePalindromes
{
    [TestFixture]
    public class DoubleBasePalindromesTest
    {
        [Test]
        public void TestMethod1()
        {
            var result = DoubleBasePalindromes.IsDoubleBasePalindrome(585);
            Assert.AreEqual(true, result);
        }
        
        [Test]
        public void TestMethod2()
        {
            var result = DoubleBasePalindromes.Main(1000000);
            Assert.AreEqual(55, result);
        }
    }
}
