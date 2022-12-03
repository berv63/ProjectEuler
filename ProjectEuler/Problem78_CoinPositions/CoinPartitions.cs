using ProjectEuler.Shared;

namespace ProjectEuler.Problem78_CoinPositions
{
    public static class CoinPartitions
    {
        public static int Main()
        {
            var partitions = new List<List<string>>();
            return 0;
        }

        public static List<List<string>> GetCoinPartitions(int n, List<List<string>> partitions)
        {
            var result = partitions.CopyValues();

            if (n == 2)
            {
                partitions.Add(new List<string> { "OO" });
                partitions.Add(new List<string> { "O", "O" });
                return partitions;
            }
            else
            {
                foreach(var sequence in partitions.Where(x => ShouldAppendValue(x, n)))
                {
                    var appendSequence = sequence.First(x => x.Length == n);
                    appendSequence += "0";
                }
            }

            return new List<List<string>>();
        }

        public static bool AppendValue(List<string> sequence, int number)
        {
            return true;
        }

        private static bool ShouldAppendValue(List<string> sequence, int number)
        {
            return number > 1 && sequence.Any(x => x.Length == number);
        }
    }
}
