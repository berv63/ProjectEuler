using System.Collections.Generic;
using NUnit.Framework;
using ProjectEuler.Problem54_PokerHands;
using ProjectEuler.Shared;

namespace ProjectEuler.Tests.Problem54_PokerHands
{
    [TestFixture]
    public class PokerHandsTest
    {
        [Test]
        public void TestMethod1()
        {
            var hand = new List<string> { "5H 5C 6S 7S KD 2C 3S 8S 8D TD" };
            var result = PokerHands.Main(hand);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestMethod2()
        {
            var hand = new List<string> { "5D 8C 9S JS AC 2C 5C 7D 8S QH" };
            var result = PokerHands.Main(hand);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void TestMethod3()
        {
            var hand = new List<string> { "2D 9C AS AH AC 3D 6D 7D TD QD" };
            var result = PokerHands.Main(hand);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestMethod4()
        {
            var hand = new List<string> { "4D 6S 9H QH QC 3D 6D 7H QD QS" };
            var result = PokerHands.Main(hand);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void TestMethod5()
        {
            var hand = new List<string> { "2H 2D 4C 4D 4S 3C 3D 3S 9S 9D" };
            var result = PokerHands.Main(hand);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void TestMethod6()
        {
            var file = FileExtensions.GetTestFileAsArray(@"\Problem54_PokerHands\poker_hands_input.txt");
            
            var result = PokerHands.Main(file);

            Assert.AreEqual(376, result);
        }
    }
}
