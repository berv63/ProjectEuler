using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using ProjectEuler.Problem54_PokerHands;

namespace ProjectEuler.Tests.Problem54_PokerHands
{
    [TestFixture]
    public class HandModelTest
    {
        [Test]
        public void TestMethod1()
        {
            var hand = new List<string> { "5H 5C 6S 7S KD 2C 3S 8S 8D TD" };
            var hands = new PlayersHandsModel(hand.First());
            var player1 = new HandModel(hands.Player1);
            var player2 = new HandModel(hands.Player2);

            Assert.AreEqual(RankEnum.OnePair, player1.Rank);
            Assert.AreEqual(CardValuesEnum.Five, player1.Match1);

            Assert.AreEqual(RankEnum.OnePair, player2.Rank);
            Assert.AreEqual(CardValuesEnum.Eight, player2.Match1);

            var didPlayer1Win = player1 > player2;
            Assert.AreEqual(false, didPlayer1Win);
        }

        [Test]
        public void TestMethod2()
        {
            var hand = new List<string> { "5D 8C 9S JS AC 2C 5C 7D 8S QH" };
            var hands = new PlayersHandsModel(hand.First());
            var player1 = new HandModel(hands.Player1);
            var player2 = new HandModel(hands.Player2);

            Assert.AreEqual(RankEnum.HighCard, player1.Rank);
            Assert.AreEqual(null, player1.Match1);
            Assert.AreEqual(CardValuesEnum.A, player1.HighCards.Last());

            Assert.AreEqual(RankEnum.HighCard, player2.Rank);
            Assert.AreEqual(null, player2.Match1);
            Assert.AreEqual(CardValuesEnum.Q, player2.HighCards.Last());

            var didPlayer1Win = player1 > player2;
            Assert.AreEqual(true, didPlayer1Win);
        }

        [Test]
        public void TestMethod3()
        {
            var hand = new List<string> { "2D 9C AS AH AC 3D 6D 7D TD QD" };
            var hands = new PlayersHandsModel(hand.First());
            var player1 = new HandModel(hands.Player1);
            var player2 = new HandModel(hands.Player2);

            Assert.AreEqual(RankEnum.ThreeOfAKind, player1.Rank);
            Assert.AreEqual(CardValuesEnum.A, player1.Match1);

            Assert.AreEqual(RankEnum.Flush, player2.Rank);
            Assert.AreEqual(null, player2.Match1);

            var didPlayer1Win = player1 > player2;
            Assert.AreEqual(false, didPlayer1Win);
        }

        [Test]
        public void TestMethod4()
        {
            var hand = new List<string> { "4D 6S 9H QH QC 3D 6D 7H QD QS" };
            var hands = new PlayersHandsModel(hand.First());
            var player1 = new HandModel(hands.Player1);
            var player2 = new HandModel(hands.Player2);

            Assert.AreEqual(RankEnum.OnePair, player1.Rank);
            Assert.AreEqual(CardValuesEnum.Q, player1.Match1);
            Assert.AreEqual(CardValuesEnum.Nine, player1.HighCards.Last());

            Assert.AreEqual(RankEnum.OnePair, player2.Rank);
            Assert.AreEqual(CardValuesEnum.Q, player2.Match1);
            Assert.AreEqual(CardValuesEnum.Seven, player2.HighCards.Last());

            var didPlayer1Win = player1 > player2;
            Assert.AreEqual(true, didPlayer1Win);
        }

        [Test]
        public void TestMethod5()
        {
            var hand = new List<string> { "2H 2D 4C 4D 4S 3C 3D 3S 9S 9D" };
            var hands = new PlayersHandsModel(hand.First());
            var player1 = new HandModel(hands.Player1);
            var player2 = new HandModel(hands.Player2);

            Assert.AreEqual(RankEnum.FullHouse, player1.Rank);
            Assert.AreEqual(CardValuesEnum.Four, player1.Match1);

            Assert.AreEqual(RankEnum.FullHouse, player2.Rank);
            Assert.AreEqual(CardValuesEnum.Three, player2.Match1);

            var didPlayer1Win = player1 > player2;
            Assert.AreEqual(true, didPlayer1Win);
        }

        [Test]
        public void TestMethod6()
        {
            var hand = new List<string> { "TH JH QH KH AH 3C 4C 5C 6C 7C" };
            var hands = new PlayersHandsModel(hand.First());
            var player1 = new HandModel(hands.Player1);
            var player2 = new HandModel(hands.Player2);

            Assert.AreEqual(RankEnum.RoyalFlush, player1.Rank);
            Assert.AreEqual(null, player1.Match1);

            Assert.AreEqual(RankEnum.StraightFlush, player2.Rank);
            Assert.AreEqual(null, player2.Match1);

            var didPlayer1Win = player1 > player2;
            Assert.AreEqual(true, didPlayer1Win);
        }
    }
}
