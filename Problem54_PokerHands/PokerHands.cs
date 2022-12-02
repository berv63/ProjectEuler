using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem54_PokerHands
{
    public class PokerHands
    {
        public int Main(List<string> inputHands)
        {
            var winner = new List<int>();

            foreach(var hand in inputHands)
            {
                var playersHands = new PlayersHandsModel(hand);

                var player1 = new HandModel(playersHands.Player1);
                var player2 = new HandModel(playersHands.Player2);

                var result = GetWinner(player1, player2);
                winner.Add(result);
            }

            return winner.Count(x => x == 1);
        }

        private int GetWinner(HandModel player1, HandModel player2)
        {
            if (player1 > player2)
                return 1;
            else if (player1 < player2)
                return 2;
            else
                return 0;
        }
    }
}
