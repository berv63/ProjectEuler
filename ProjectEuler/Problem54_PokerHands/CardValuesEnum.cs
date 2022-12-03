namespace ProjectEuler.Problem54_PokerHands
{
    public enum CardValuesEnum
    {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        T = 10,
        J = 11,
        Q = 12,
        K = 13,
        A = 14,
    }

    public static class CardValueExtensions
    {
        public static CardValuesEnum GetCardValue(this string value)
        {
            if (int.TryParse(value, out int intresult))
                return (CardValuesEnum)intresult;
            else //J,Q,K
                return (CardValuesEnum)Enum.Parse(typeof(CardValuesEnum), value);
        }
    }
}
