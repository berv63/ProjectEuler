using ProjectEuler.Shared;

namespace ProjectEuler.Problem24_LexicographicPermutations
{
    public static class LexicographicPermutations
    {
        public static string Main(List<int> values, int index)
        {
            var permuations = GetPermutations(values);
            permuations.Sort();
            return permuations[index - 1];
        }

        private static List<string> GetPermutations(List<int> values)
        {
            var result = new List<string>();

            if(values.Count == 2)
            {
                result.Add(values[0].ToString() + values[1].ToString());
                result.Add(values[1].ToString() + values[0].ToString());
                return result;
            }

            for (var i = 0; i < values.Count; i++)
            {
                var tempList = values.CopyValues();
                tempList.RemoveAt(i);
                
                var subPermutations = GetPermutations(tempList);
                foreach (var permutation in subPermutations)
                    result.Add(values[i].ToString() + permutation);
            }

            return result;
        }
    }
}
