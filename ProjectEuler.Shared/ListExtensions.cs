namespace ProjectEuler.Shared
{
    public static class ListExtensions
    {
        public static List<T> CopyValues<T>(this List<T> values)
        {
            var result = new List<T>();
            for (var i = 0; i < values.Count; i++)
            {
                result.Add(values[i]);
            }

            return result;
        }
        
        public static int ConcatIntList(this List<int> values)
        {
            return int.Parse(string.Join("", values.Select(x => x.ToString())));
        }
        
        public static void Rotate<T>(this List<T> list)
        {
            var temp = list[0];
            for (var j = 0; j < list.Count - 1; j++)
            {
                list[j] = list[j + 1];
            }

            list[^1] = temp;
        }
    }
}
