using ProjectEuler.Shared;

namespace ProjectEuler.Problem31_CoinSum
{
    public static class CoinSum
    {
        private static List<decimal> Denominations = new() {2, 1, .5m, .2m, .1m, .05m, .02m, .01m};
        private static Dictionary<decimal, List<List<decimal>>> WaysToGet = new();

        public static int Main(decimal value)
        {
            var resultList = new List<List<int>>();
            var currentList = new List<int>();
            GetRecursive(value, currentList, resultList, int.MinValue);

            return resultList.Count;
        }

        private static void GetRecursive(decimal maxValue, List<int> currentList, List<List<int>> resultList, int lastIndexUsed)
        {
            var currentValue = maxValue;
            
            if (currentValue == 0)
            {
                resultList.Add(currentList);
                return;
            }

            foreach (var denomination in Denominations.Where(x => x <= currentValue && Denominations.IndexOf(x) >= lastIndexUsed))
            {
                var thisIndex = Denominations.IndexOf(denomination);
                var anotherList = currentList.CopyValues();
                anotherList.Add(thisIndex);
                
                var newValue = currentValue - denomination;
                GetRecursive(newValue, anotherList, resultList, thisIndex);
            }
        }
    }
}