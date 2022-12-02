using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem24_LexicographicPermutations;
using System.Collections.Generic;

namespace Problem24_LexicographicPermutations_Test
{
    [TestClass]
    public class LexicographicPermutationsTest
    {
        private LexicographicPermutations LexicographicPermutations { get; set; }

        [TestInitialize]
        public void Init()
        {
            LexicographicPermutations = new LexicographicPermutations();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var values = new List<int> { 0, 1, 2 };
            var result = LexicographicPermutations.Main(values, 4);
            Assert.AreEqual("120", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var values = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = LexicographicPermutations.Main(values, 1000000);
            Assert.AreEqual("2783915460", result);
        }
    }
}
