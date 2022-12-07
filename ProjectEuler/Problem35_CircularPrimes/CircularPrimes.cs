using System.Data;
using ProjectEuler.Shared;

namespace ProjectEuler.Problem35_CircularPrimes
{
    public static class CircularPrimes
    {
        public static int Main(int maxValue)
        {
            var result = new List<int>{2, 11};
            var resetPoints = new List<int>();
            
            var n = 3;
            while(n <= maxValue)
            {
                var isPrime = n.IsPrime();
                var circulations = new List<int>();
                if (!result.Contains(n) && isPrime && AreAllCirculationsPrime(n, circulations))
                {
                    result.AddRange(circulations);
                }
             
                n += 2;

                var nLength = n.ToString().Length;
                if (n.ToString().Count(x => x == '0') == nLength - 2 && n.ToString().Last() == '1')
                {
                    var newArray = new List<int>();
                    for (int i = 0; i < nLength; i++)
                    {
                        newArray.Add(int.Parse(n.ToString()[0].ToString()));
                    }

                    n = newArray.ConcatIntList();
                    if (n % 2 == 0)
                        n++;
                    
                    resetPoints.Add(n);
                }
                    
            }

            return result.Count();
        }

        private static bool AreAllCirculationsPrime(int value, List<int> circulations)
        {
            var intList = value.GetDigitsAsList();
            for (int i = 0; i < intList.Count; i++)
            {
                var currentValue = intList.ConcatIntList();
                if (!intList.ConcatIntList().IsPrime())
                    break;
                
                circulations.Add(currentValue);
                intList.Rotate();
            }

            return circulations.Count() == intList.Count;
        }
    }
}