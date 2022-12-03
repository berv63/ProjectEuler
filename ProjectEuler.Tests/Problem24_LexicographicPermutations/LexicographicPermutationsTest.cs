using System.Collections.Generic;
using NUnit.Framework;
using ProjectEuler.Problem24_LexicographicPermutations;

namespace ProjectEuler.Tests.Problem24_LexicographicPermutations
{
    [TestFixture]
    public class LexicographicPermutationsTest
    {
        [Test]
        public void TestMethod1()
        {
            var values = new List<int> { 0, 1, 2 };
            var result = LexicographicPermutations.Main(values, 4);
            Assert.AreEqual("120", result);
        }

        [Test]
        public void TestMethod2()
        {
            var values = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = LexicographicPermutations.Main(values, 1000000);
            Assert.AreEqual("2783915460", result);
        }
    }
}
