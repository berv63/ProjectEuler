using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem29_DistinctPowers
{
    public class DistinctPowers
    {
        public int Main(int a, int b)
        {
            var resultList = new List<double>();

            for(var i = 2; i <= a; i++)
            {
                for(var j = 2; j <= b; j++)
                {
                    resultList.Add(Math.Pow(i, j));
                }
            }

            var result = resultList.Distinct().Count();
            return result;
        }
    }
}
