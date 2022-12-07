using ProjectEuler.Shared;

namespace ProjectEuler.Problem33_DigitCancellingFractions
{
    public static class DigitCancellingFractions
    {
        public static decimal Main()
        {
            List<(int, int, decimal)> fractions = new List<(int, int, decimal)>();

            for (int i = 10; i < 100; i++)
            {
                if (!i.IsDigitOneSmallerThanDigitTwo() || !i.IsPandigital() || i.ContainsDigit(0))
                    continue;

                var numerator = i;

                for (int j = 1; j < 9; j++)
                {
                    var iDigit2 = i.ToString()[1].ToString();
                    var jDigit = j.ToString();

                    var denominator = int.Parse(string.Join("", iDigit2.Concat(jDigit)));

                    var iDigit1 = i.ToString()[0].ToString();
                    
                    if ((decimal) numerator / denominator == ((decimal) int.Parse(iDigit1) / int.Parse(jDigit)))
                        fractions.Add((numerator, denominator, (decimal)numerator/denominator));
                }
            }

            return fractions.Aggregate((decimal)1, (acc, val) => acc * val.Item3);;
        }
    }
}