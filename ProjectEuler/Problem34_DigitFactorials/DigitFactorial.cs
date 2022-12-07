using ProjectEuler.Shared;

namespace ProjectEuler.Problem34_DigitFactorials
{
    public static class DigitFactorial
    {
        private static readonly Dictionary<int, int> Factorials = new()
        {
            {0, 1},
            {1, 1},
            {2, 2 * 1},
            {3, 3 * 2 * 1},
            {4, 4 * 3 * 2 * 1},
            {5, 5 * 4 * 3 * 2 * 1},
            {6, 6 * 5 * 4 * 3 * 2 * 1},
            {7, 7 * 6 * 5 * 4 * 3 * 2 * 1},
            {8, 8 * 7 * 6 * 5 * 4 * 3 * 2 * 1},
            {9, 9 * 8 * 7 * 6 * 5 * 4 * 3 * 2 * 1},
        };

        public static int Main()
        {
            var equalNumber = new List<int>();
            for (var i = 10; i < int.MaxValue; i++)
            {
                var factorialSums = i.GetDigitsAsList().Select(x => Factorials[x]).Sum();
                if(factorialSums == i)
                    equalNumber.Add(i);

                if (equalNumber.Count() == 2)
                    break;
            }

            return equalNumber.Sum();
        }
    }
}