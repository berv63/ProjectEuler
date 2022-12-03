namespace ProjectEuler.Problem29_DistinctPowers
{
    public static class DistinctPowers
    {
        public static int Main(int a, int b)
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
