namespace ProjectEuler.Problem54_PokerHands
{
    public class PlayersHandsModel
    {
        public List<string> Player1 { get; set; } = new List<string>();
        public List<string> Player2 { get; set; } = new List<string>();

        public PlayersHandsModel(string inputHand)
        {
            var cards = inputHand.Split(' ');
            Player1 = PopulatePlayerHands(0, 4, cards);
            Player2 = PopulatePlayerHands(5, 9, cards);
        }

        private List<string> PopulatePlayerHands(int startCard, int endCard, string[] cards)
        {
            var result = new List<string>();

            for (var i = startCard; i <= endCard; i++)
            {
                result.Add(cards[i]);
            }

            return result;
        }
    }
}
