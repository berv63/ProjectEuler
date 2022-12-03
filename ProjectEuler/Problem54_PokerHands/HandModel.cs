using ProjectEuler.Shared;

namespace ProjectEuler.Problem54_PokerHands
{
    public class HandModel
    {
        private List<string> Hand { get; set; }
        private List<CardValuesEnum> HandValues { get; set; }

        public RankEnum Rank { get; set; }
        public CardValuesEnum? Match1 { get; set; } //used for pair, three of a kind, full house, and four of a kind
        public CardValuesEnum? Match2 { get; set; } //used for 2 pair and full house

        public List<CardValuesEnum> HighCards { get; set; } = new List<CardValuesEnum>(); //used for all remaining cards in order for comparison

        public HandModel(List<string> values)
        {
            this.Hand = values;
            PopulateHandValues();
            PopulateResults();
        }

        public string GetHand()
        {
            var handString = "";
            foreach(var value in HandValues)
            {
                handString += value.ToString() + " ";
            }
            return handString;
        }

        public void PopulateResults()
        {
            PopulateRankAndMatches();
            PopulateHighCards();
        }

        private void PopulateRankAndMatches()
        {
            var disticntValues = HandValues.Distinct().Count();

            switch (disticntValues)
            {
                case 2: //Full House or 4 of a kind
                    if (HandValues[0] == HandValues[1] && HandValues[3] == HandValues[4])
                    {
                        Rank = RankEnum.FullHouse;
                        Match1 = HandValues[2]; //The middle card is guaranteed to be the one with the most
                        Match2 = HandValues[1] < HandValues[3] ? HandValues[1] : HandValues[3];
                    }
                    else
                    {
                        Rank = RankEnum.FourOfAKind;
                        Match1 = HandValues[1]; //the 2nd = 4th cards are guaranteed to be in the set
                    }
                    break;
                case 3:
                    PopulateMatches();
                    if (Match2.HasValue)
                        Rank = RankEnum.TwoPair;
                    else
                        Rank = RankEnum.ThreeOfAKind;
                    break;
                case 4:
                    PopulateMatches();
                    Rank = RankEnum.OnePair;
                    break;
                case 5:
                    PopulateNoMatchRank();
                    break;
            }
        }

        private void PopulateNoMatchRank()
        {
            var isFlush = true;
            var isStraight = true;
            var isRoyal = HandValues[0] == CardValuesEnum.T;

            for (var i = 1; i < 5; i++)
            {
                isFlush = isFlush && Hand[i][1] == Hand[i - 1][1];
                isStraight = isStraight && HandValues[i] == HandValues[i - 1] + 1;
                isRoyal = isRoyal && isStraight && isFlush;
            }

            if (isRoyal)
                Rank = RankEnum.RoyalFlush;
            else if (isFlush && isStraight)
                Rank = RankEnum.StraightFlush;
            else if (isStraight)
                Rank = RankEnum.Straight;
            else if (isFlush)
                Rank = RankEnum.Flush;
            else
                Rank = RankEnum.HighCard;
        }

        private void PopulateMatches()
        {
            for(var i = 1; i < 5; i++)
            {
                if(HandValues[i] == HandValues[i - 1])
                {
                    if (Match1 == null)
                        Match1 = HandValues[i];
                    else
                    {
                        if (Match1 == HandValues[i])
                            continue;
                        else
                            Match2 = HandValues[i];
                    }
                }
            }
        }

        private void PopulateHighCards()
        {
            var values = HandValues.CopyValues();

            for (var i = 0; i < 5; i++)
            {
                if(Match1.HasValue && HandValues[i] == Match1)
                    values.Remove(Match1.Value);
                if (Match2.HasValue && HandValues[i] == Match2)
                    values.Remove(Match2.Value);
            }

            HighCards = values;
        }

        private void PopulateHandValues()
        {
            var result = new List<CardValuesEnum>();
            for (var i = 0; i < 5; i++)
            {
                result.Add(Hand[i].Substring(0, 1).GetCardValue());
            }

            result.Sort();
            HandValues = result;
        }

        public static bool operator <(HandModel hand1, HandModel hand2)
        {
            var result = true;

            if (hand1.Rank > hand2.Rank)
                result = false;
            else if (hand1.Rank < hand2.Rank)
                result = true;
            else if (!hand2.Match1.HasValue && hand1.Match1.HasValue)
                result = false;
            else if (hand1.Match1.HasValue && hand2.Match1.HasValue && hand1.Match1.Value > hand2.Match1.Value)
                result = false;
            else if (hand1.Match1.HasValue && hand2.Match1.HasValue && hand1.Match1.Value < hand2.Match1.Value)
                result = true;
            else if (!hand2.Match2.HasValue && hand1.Match2.HasValue)
                result = false;
            else if (hand1.Match2.HasValue && hand2.Match2.HasValue && hand1.Match2.Value > hand2.Match2.Value)
                result = false;
            else if (hand1.Match2.HasValue && hand2.Match2.HasValue && hand1.Match2.Value < hand2.Match2.Value)
                result = true;
            else
            {
                for(var i = hand1.HighCards.Count - 1; i >= 0; i--) //Start with the high card
                {
                    if (hand1.HighCards[i] == hand2.HighCards[i])
                        continue;
                    
                    result = result && hand1.HighCards[i] < hand2.HighCards[i];
                    break;
                }
            }

            return result;
        }

        public static bool operator >(HandModel hand1, HandModel hand2)
        {
            var result = true;

            if (hand1.Rank < hand2.Rank)
                result = false;
            else if (hand1.Rank > hand2.Rank)
                result = true;
            else if (!hand1.Match1.HasValue && hand2.Match1.HasValue)
                result = false;
            else if (hand1.Match1.HasValue && hand2.Match1.HasValue && hand1.Match1.Value < hand2.Match1.Value)
                result = false;
            else if (hand1.Match1.HasValue && hand2.Match1.HasValue && hand1.Match1.Value > hand2.Match1.Value)
                result = true;
            else if (!hand1.Match2.HasValue && hand2.Match2.HasValue)
                result = false;
            else if (hand1.Match2.HasValue && hand2.Match2.HasValue && hand1.Match2.Value < hand2.Match2.Value)
                result = false;
            else if (hand1.Match2.HasValue && hand2.Match2.HasValue && hand1.Match2.Value > hand2.Match2.Value)
                result = true;
            else
            {
                for (var i = hand2.HighCards.Count - 1; i >= 0; i--) //Start with the high card
                {
                    if (hand1.HighCards[i] == hand2.HighCards[i])
                        continue;
                    
                    result = result && hand1.HighCards[i] > hand2.HighCards[i];
                    break;
                }
            }

            return result;
        }

        public static bool operator ==(HandModel hand1, HandModel hand2)
        {
            var result = hand1.Rank == hand2.Rank &&
                hand1.Match1 == hand2.Match1 &&
                hand1.Match2 == hand2.Match2 &&
                IsHighCardMatch(hand1, hand2);

            return result;
        }

        public static bool operator !=(HandModel hand1, HandModel hand2)
        {
            var result = hand1.Rank != hand2.Rank &&
                hand1.Match1 != hand2.Match1 &&
                hand1.Match2 != hand2.Match2 &&
                !IsHighCardMatch(hand1, hand2);
            
            return result;
        }

        private static bool IsHighCardMatch(HandModel hand1, HandModel hand2)
        {
            var result = true;
            for (var i = 0; i < hand1.HighCards.Count; i++)
            {
                result = result && hand1.HighCards[i] == hand2.HighCards[i];
            }
            return result;
        }
    }
}
