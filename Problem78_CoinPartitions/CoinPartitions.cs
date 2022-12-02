using aShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace Problem78_CoinPartitions
{
    public class CoinPartitions
    {
        public int Main()
        {
            var partitions = new List<List<string>>();
            return 0;
        }

        public List<List<string>> GetCoinPartitions(int n, List<List<string>> partitions)
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

        public bool AppendValue(List<string> sequence, int number)
        {
            return true;
        }

        public bool ShouldAppendValue(List<string> sequence, int number)
        {
            var result = false;

            if (number > 1 && sequence.Any(x => x.Length == number))
                result = true;

            return result;
        }
    }
}
